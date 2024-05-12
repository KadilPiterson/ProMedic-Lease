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
            var cached= Cache.Rentals.Get(rental.Id);
            if (cached != null)
            {
                Cache.Rentals.Remove(cached.Id);
            }
            Cache.Rentals.Add(rental.Id, rental);
        }

        public Rental GetById(long id)
        {
            var cached = Cache.Rentals.Get(id);
            if (cached != null)
            {
                Cache.Rentals.Remove(cached.Id);
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@RentalId", id) };
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
            Cache.Rentals.Update(rental.Id, rental);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@RentalId", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Rentals.Remove(id);
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
                new SqlParameter("@Status", rental.IsActive),
                new SqlParameter("@Comments", rental.Comments ?? (object)DBNull.Value)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@RentalId", rental.Id));
            }

            return parameters.ToArray();
        }

        private Rental MapFromDataRow(DataRow row)
        {
            long id = Convert.ToInt64(row["RentalId"]);
            return Cache.Rentals.GetOrCreate(id, () => Create(row));
        }

        private Rental Create(DataRow row)
        {
            var equipment = Cache.Equipments.GetOrCreate(Convert.ToInt64(row["EquipmentId"]), () => new Equipment
            {
                Id = Convert.ToInt64(row["EquipmentId"]),
                Name = row["EquipmentName"] as string ?? string.Empty,
                InventoryNumber = row["InventoryNumber"] as string ?? string.Empty,
                PurchaseDate = Convert.ToDateTime(row["EquipmentPurchaseDate"]),
                InvoiceNumber = row["EquipmentInvoiceNumber"] as string ?? string.Empty,
                IdentificationNumber = row["EquipmentIdentificationNumber"] as string ?? string.Empty,
                IsServiced = Convert.ToBoolean(row["EquipmentIsServiced"]),
                IsInTransit = Convert.ToBoolean(row["EquipmentIsInTransit"]),
                DisposalDate = row.IsNull("EquipmentDisposalDate") ? null : (DateTime?)Convert.ToDateTime(row["EquipmentDisposalDate"]),
                DailyRentalPrice = Convert.ToDecimal(row["EquipmentDailyRentalPrice"]),
                EquipmentType = Cache.EquipmentTypes.GetOrCreate(Convert.ToInt64(row["EquipmentTypeId"]), () => new EquipmentType
                {
                    Id = Convert.ToInt64(row["EquipmentTypeId"]),
                    Name = row["EquipmentTypeName"] as string ?? string.Empty,
                    Description = row["EquipmentTypeDescription"] as string ?? string.Empty
                })
            });

            var client = Cache.Clients.GetOrCreate(Convert.ToInt64(row["ClientId"]), () => new Client
            {
                Id = Convert.ToInt64(row["ClientId"]),
                FirstName = row["ClientFirstName"] as string ?? string.Empty,
                LastName = row["ClientLastName"] as string ?? string.Empty,
                Pesel = row["ClientPesel"] as string ?? string.Empty,
                Street = row["ClientStreet"] as string ?? string.Empty,
                HouseNumber = Convert.ToInt32(row["ClientHouseNumber"]),
                ApartmentNumber = Convert.ToInt32(row["ClientApartmentNumber"]),
                PostalCode = row["ClientPostalCode"] as string ?? string.Empty,
                City = row["ClientCity"] as string ?? string.Empty,
                Email = row["ClientEmail"] as string ?? string.Empty,
                Phone = row["ClientPhoneNumber"] as string ?? string.Empty,
                IsActive = Convert.ToBoolean(row["ClientActive"])
            });

            var employee = Cache.Employees.GetOrCreate(Convert.ToInt64(row["EmployeeId"]), () => new Employee
            {
                Id = Convert.ToInt64(row["EmployeeId"]),
                FirstName = row["EmployeeFirstName"] as string ?? string.Empty,
                LastName = row["EmployeeLastName"] as string ?? string.Empty,
                Email = row["EmployeeEmail"] as string ?? string.Empty,
                Phone = row["EmployeePhone"] as string ?? string.Empty,
                Pesel = row["EmployeePesel"] as string ?? string.Empty,
                Street = row["EmployeeStreet"] as string ?? string.Empty,
                HouseNumber = Convert.ToInt32(row["EmployeeHouseNumber"]),
                ApartmentNumber = Convert.ToInt32(row["EmployeeApartmentNumber"]),
                PostalCode = row["EmployeePostalCode"] as string ?? string.Empty,
                City = row["EmployeeCity"] as string ?? string.Empty,
                EmploymentDate = Convert.ToDateTime(row["EmployeeEmploymentDate"]),
                TerminationDate = row.IsNull("EmployeeTerminationDate") ? null : (DateTime?)Convert.ToDateTime(row["EmployeeTerminationDate"]),
                Salary = Convert.ToDecimal(row["EmployeeSalary"]),
                IsActive = Convert.ToBoolean(row["EmployeeActive"]),
                Department = Cache.Departments.GetOrCreate(Convert.ToInt64(row["DepartmentId"]), () => new Department
                {
                    Id = Convert.ToInt64(row["DepartmentId"]),
                    Name = row["DepartmentName"] as string ?? string.Empty
                }),
                Position = Cache.Positions.GetOrCreate(Convert.ToInt64(row["PositionId"]), () => new Position
                {
                    Id = Convert.ToInt64(row["PositionId"]),
                    Name = row["PositionName"] as string ?? string.Empty
                })
            });

            return new Rental
            {
                Id = Convert.ToInt64(row["RentalId"]),
                Equipment = equipment,
                StartDate = Convert.ToDateTime(row["StartDate"]),
                EndDate = row.IsNull("EndDate") ? null : (DateTime?)Convert.ToDateTime(row["EndDate"]),
                Client = client,
                Employee = employee,
                Comments = row.IsNull("Comments") ? null : row["Comments"] as string,
                IsActive = Convert.ToBoolean(row["Status"])
            };
        }

    }
}
