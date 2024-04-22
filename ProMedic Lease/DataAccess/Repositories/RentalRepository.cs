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
        private readonly Dictionary<string, string> _rentalQueries;

        public RentalRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _rentalQueries = QueryConfig.Instance.Queries["Rental"];
        }

        public void Add(Rental rental)
        {
            string query = _rentalQueries["Add"];
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EquipmentId", rental.Equipment.Id),
                new SqlParameter("@StartDate", rental.StartDate),
                new SqlParameter("@EndDate", rental.EndDate ?? (object)DBNull.Value),
                new SqlParameter("@ClientId", rental.Client.Id),
                new SqlParameter("@EmployeeId", rental.Employee.Id),
                new SqlParameter("@Comments", rental.Comments ?? (object)DBNull.Value),
                new SqlParameter("@Status", rental.Status)
            };
            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public Rental GetById(long id)
        {
            string query = _rentalQueries["GetById"];
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@Id", id)
            };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = dataTable.Rows[0];
            return MapRentalFromDataRow(row);
        }

        public IEnumerable<Rental> GetAll()
        {
            string query = _rentalQueries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapRentalFromDataRow(row)).ToList();
        }

        public void Update(Rental rental)
        {
            string query = _rentalQueries["Update"];
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", rental.Id),
                new SqlParameter("@EquipmentId", rental.Equipment.Id),
                new SqlParameter("@StartDate", rental.StartDate),
                new SqlParameter("@EndDate", rental.EndDate ?? (object)DBNull.Value),
                new SqlParameter("@ClientId", rental.Client.Id),
                new SqlParameter("@EmployeeId", rental.Employee.Id),
                new SqlParameter("@Comments", rental.Comments ?? (object)DBNull.Value),
                new SqlParameter("@Status", rental.Status)
            };
            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = _rentalQueries["Delete"];
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        private Rental MapRentalFromDataRow(DataRow row)
        {
            return new Rental
            {
                Id = Convert.ToInt64(row["id"]),
                Equipment = new Equipment
                {
                    Id = Convert.ToInt64(row["sprzet_id"]),
                    Name = row["sprzet_nazwa"] as string ?? string.Empty,
                    InventoryNumber = row["numer_inwentarzowy"] as string ?? string.Empty,
                    PurchaseDate = Convert.ToDateTime(row["data_zakupu"]),
                    InvoiceNumber = row["numer_faktury"] as string ?? string.Empty,
                    IdentificationNumber = row["numer_identyfikacyjny"] as string ?? string.Empty,
                    IsServiced = Convert.ToBoolean(row["czy_serwis"]),
                    IsInTransit = Convert.ToBoolean(row["czy_w_drodze"]),
                    DisposalDate = row["data_likwidacji"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["data_likwidacji"]),
                    Status = Convert.ToInt32(row["sprzet_status"]),
                    DailyRentalPrice = Convert.ToDecimal(row["cena_za_dzien"]),
                    EquipmentType = new EquipmentType
                    {
                        Id = Convert.ToInt64(row["typ_id"]),
                        Name = row["typ_nazwa"] as string ?? string.Empty,
                        Description = row["typ_opis"] as string ?? string.Empty
                    }
                },
                StartDate = Convert.ToDateTime(row["data_start"]),
                EndDate = row["data_koniec"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["data_koniec"]),
                Client = new Client
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
                },
                Employee = new Employee
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
                    TerminationDate = row["data_zwolnienia"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["data_zwolnienia"]),
                    Salary = Convert.ToDecimal(row["zarobek"]),
                    IsActive = Convert.ToBoolean(row["active"]),
                    Department = new Department { Name = row["dzial_nazwa"] as string ?? string.Empty },
                    Position = new Position { Name = row["stanowisko_nazwa"] as string ?? string.Empty }
                },
                Comments = row["uwagi"] as string ?? string.Empty,
                Status = Convert.ToInt32(row["status"])
            };
        }
    }
} 