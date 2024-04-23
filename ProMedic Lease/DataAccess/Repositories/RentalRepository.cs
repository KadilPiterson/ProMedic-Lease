using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ProMedic_Lease.DataAccess.Repositories
{
    public class RentalRepository : IRentalRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public RentalRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["Rental"];
        }

        public void Add(Rental rental)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(rental);
            _databaseManager.ExecuteNonQuery(query, parameters);
            var cached= Cache.RentalsCache.Get(rental.Id);
            if (cached != null)
            {
                Cache.RentalsCache.Remove(cached.Id);
            }
            Cache.RentalsCache.Add(rental.Id, rental);
        }

        public Rental GetById(long id)
        {
            var cached = Cache.RentalsCache.Get(id);
            if (cached != null)
            {
                Cache.RentalsCache.Remove(cached.Id);
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<Rental> GetAll()
        {
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(Rental rental)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(rental, includeId: true);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.RentalsCache.Update(rental.Id, rental);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.RentalsCache.Remove(id);
        }

        private SqlParameter[] BuildParameters(Rental rental, bool includeId = false)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@EquipmentId", rental.Equipment.Id),
                new SqlParameter("@ClientId", rental.Client.Id),
                new SqlParameter("@EmployeeId", rental.Employee.Id),
                new SqlParameter("@StartDate", rental.StartDate),
                new SqlParameter("@EndDate", rental.EndDate ?? (object)DBNull.Value),
                new SqlParameter("@Status", rental.Status),
                new SqlParameter("@Comments", rental.Comments ?? (object)DBNull.Value)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@Id", rental.Id));
            }

            return parameters.ToArray();
        }

        private Rental MapFromDataRow(DataRow row)
        {
            long id = Convert.ToInt64(row["id"]);
            return Cache.RentalsCache.GetOrCreate(id, () => Create(row));
        }

        private Rental Create(DataRow row)
        {
            var equipment = Cache.EquipmentsCache.GetOrCreate(Convert.ToInt64(row["sprzet_id"]), () => new Equipment
            {
                Id = Convert.ToInt64(row["sprzet_id"]),
                Name = row["sprzet_nazwa"] as string ?? string.Empty,
                InventoryNumber = row["numer_inwentarzowy"] as string ?? string.Empty,
                PurchaseDate = Convert.ToDateTime(row["data_zakupu"]),
                InvoiceNumber = row["numer_faktury"] as string ?? string.Empty,
                IdentificationNumber = row["numer_identyfikacyjny"] as string ?? string.Empty,
                IsServiced = Convert.ToBoolean(row["czy_serwis"]),
                IsInTransit = Convert.ToBoolean(row["czy_w_drodze"]),
                DisposalDate = row.IsNull("data_likwidacji") ? null : Convert.ToDateTime(row["data_likwidacji"]),
                Status = Convert.ToInt32(row["sprzet_status"]),
                DailyRentalPrice = Convert.ToDecimal(row["cena_za_dzien"]),
                EquipmentType = Cache.EquipmentTypesCache.GetOrCreate(Convert.ToInt64(row["typ_id"]), () => new EquipmentType
                {
                    Id = Convert.ToInt64(row["typ_id"]),
                    Name = row["typ_nazwa"] as string ?? string.Empty,
                    Description = row["typ_opis"] as string ?? string.Empty
                })
            });

            var client = Cache.ClientsCache.GetOrCreate(Convert.ToInt64(row["klient_id"]), () => new Client
            {
                Id = Convert.ToInt64(row["klient_id"]),
                FirstName = row["klient_imie"] as string ?? string.Empty,
                LastName = row["klient_nazwisko"] as string ?? string.Empty,
                Pesel = row["klient_pesel"] as string ?? string.Empty,
                Street = row["klient_ulica"] as string ?? string.Empty,
                HouseNumber = row["klient_nr_domu"] as string ?? string.Empty,
                ApartmentNumber = row["klient_lokal"] as string ?? string.Empty,
                PostalCode = row["klient_kod_pocztowy"] as string ?? string.Empty,
                City = row["klient_miejscowosc"] as string ?? string.Empty,
                Email = row["klient_email"] as string ?? string.Empty,
                Phone = row["numer_telefonu"] as string ?? string.Empty
            });

            var employee = Cache.EmployeesCache.GetOrCreate(Convert.ToInt64(row["pracownik_id"]), () => new Employee
            {
                Id = Convert.ToInt64(row["pracownik_id"]),
                FirstName = row["pracownik_imie"] as string ?? string.Empty,
                LastName = row["pracownik_nazwisko"] as string ?? string.Empty,
                Username = row["username"] as string ?? string.Empty,
                Email = row["pracownik_email"] as string ?? string.Empty,
                Phone = row["pracownik_telefon"] as string ?? string.Empty,
                Pesel = row["pracownik_pesel"] as string ?? string.Empty,
                Street = row["pracownik_ulica"] as string ?? string.Empty,
                HouseNumber = row["pracownik_nr_domu"] as string ?? string.Empty,
                ApartmentNumber = row["pracownik_lokal"] as string ?? string.Empty,
                PostalCode = row["pracownik_kod_pocztowy"] as string ?? string.Empty,
                City = row["pracownik_miejscowosc"] as string ?? string.Empty,
                EmploymentDate = Convert.ToDateTime(row["data_zatrudnienia"]),
                TerminationDate = row.IsNull("data_zwolnienia") ? null : Convert.ToDateTime(row["data_zwolnienia"]),
                Salary = Convert.ToDecimal(row["zarobek"]),
                IsActive = Convert.ToBoolean(row["active"]),
                Department = Cache.DepartmentsCache.GetOrCreate(Convert.ToInt64(row["dzial_id"]), () => new Department
                {
                    Id = Convert.ToInt64(row["dzial_id"]),
                    Name = row["dzial_nazwa"] as string ?? string.Empty
                }),
                Position = Cache.PositionsCache.GetOrCreate(Convert.ToInt64(row["stanowisko_id"]), () => new Position
                {
                    Id = Convert.ToInt64(row["stanowisko_id"]),
                    Name = row["stanowisko_nazwa"] as string ?? string.Empty
                })
            });

            return new Rental
            {
                Id = Convert.ToInt64(row["id"]),
                Equipment = equipment,
                StartDate = Convert.ToDateTime(row["data_start"]),
                EndDate = row.IsNull("data_koniec") ? null : Convert.ToDateTime(row["data_koniec"]),
                Client = client,
                Employee = employee,
                Comments = row.IsNull("uwagi") ? null : row["uwagi"] as string,
                Status = Convert.ToInt32(row["status"])
            };
        }
    }
}
