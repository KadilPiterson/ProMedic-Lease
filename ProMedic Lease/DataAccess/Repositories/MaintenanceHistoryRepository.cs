using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ProMedic_Lease.DataAccess.Repositories
{
    public class MaintenanceHistoryRepository : IMaintenanceHistoryRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public MaintenanceHistoryRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["MaintenanceHistory"];
        }

        public void Add(MaintenanceHistory maintenanceHistory)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(maintenanceHistory);
            _databaseManager.ExecuteNonQuery(query, parameters);

            var cached = Cache.MaintenanceHistory.Get(maintenanceHistory.Id);
            if (cached != null)
            {
                Cache.MaintenanceHistory.Remove(cached.Id);
            }
            Cache.MaintenanceHistory.Add(maintenanceHistory.Id, maintenanceHistory);
        }

        public MaintenanceHistory GetById(long id)
        {
            var cached = Cache.MaintenanceHistory.Get(id);
            if (cached != null)
            {
                return cached;
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@MaintenanceHistoryId", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<MaintenanceHistory> GetAll()
        {
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(MaintenanceHistory maintenanceHistory)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(maintenanceHistory, includeId: true);
            _databaseManager.ExecuteNonQuery(query, parameters);

            Cache.MaintenanceHistory.Update(maintenanceHistory.Id, maintenanceHistory);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@MaintenanceHistoryId", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);

            Cache.MaintenanceHistory.Remove(id);
        }

        private SqlParameter[] BuildParameters(MaintenanceHistory maintenanceHistory, bool includeId = false)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@EquipmentId", maintenanceHistory.Equipment.Id),
                new SqlParameter("@EmployeeId", maintenanceHistory.Employee.Id),
                new SqlParameter("@DateStart", maintenanceHistory.DateStart),
                new SqlParameter("@DateEnd", maintenanceHistory.DateEnd ?? (object)DBNull.Value),
                new SqlParameter("@Description", maintenanceHistory.Description ?? (object)DBNull.Value),
                new SqlParameter("@Cost", maintenanceHistory.Cost),
                new SqlParameter("@Status", maintenanceHistory.IsActive)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@MaintenanceHistoryId", maintenanceHistory.Id));
            }

            return parameters.ToArray();
        }

        private MaintenanceHistory MapFromDataRow(DataRow row)
        {
            long id = Convert.ToInt64(row["MaintenanceHistoryId"]);
            return Cache.MaintenanceHistory.GetOrCreate(id, () => Create(row));
        }

        private MaintenanceHistory Create(DataRow row)
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

            var employee = Cache.Employees.GetOrCreate(Convert.ToInt64(row["EmployeeId"]), () => new Employee
            {
                Id = Convert.ToInt64(row["EmployeeId"]),
                FirstName = row["EmployeeFirstName"] as string ?? string.Empty,
                LastName = row["EmployeeLastName"] as string ?? string.Empty,
                IsActive = Convert.ToBoolean(row["EmployeeActive"]),
                Email = row["EmployeeEmail"] as string ?? string.Empty,
                Phone = row["EmployeePhone"] as string ?? string.Empty,
                Pesel = row["EmployeePesel"] as string ?? string.Empty,
                Street = row["EmployeeStreet"] as string ?? string.Empty,
                HouseNumber = row.Field<int>("EmployeeHouseNumber"),
                ApartmentNumber = row.Field<int>("EmployeeApartmentNumber"),
                PostalCode = row["EmployeePostalCode"] as string ?? string.Empty,
                City = row["EmployeeCity"] as string ?? string.Empty,
                EmploymentDate = Convert.ToDateTime(row["EmployeeEmploymentDate"]),
                TerminationDate = row.IsNull("EmployeeTerminationDate") ? (DateTime?)null : Convert.ToDateTime(row["TerminationDate"]),
                Salary = Convert.ToDecimal(row["EmployeeSalary"]),
                Department = Cache.Departments.GetOrCreate(Convert.ToInt64(row["EmployeeDepartmentId"]), () => new Department
                {
                    Id = Convert.ToInt64(row["DepartmentId"]),
                    Name = row["DepartmentName"] as string ?? string.Empty
                }),
                Position = Cache.Positions.GetOrCreate(Convert.ToInt64(row["EmployeePositionId"]), () => new Position
                {
                    Id = Convert.ToInt64(row["PositionId"]),
                    Name = row["PositionName"] as string ?? string.Empty
                })
            });

            return new MaintenanceHistory
            {
                Id = Convert.ToInt64(row["MaintenanceHistoryId"]),  
                Equipment = equipment, 
                Employee = employee,   
                DateStart = Convert.ToDateTime(row["DateStart"]),  
                DateEnd = row["DateEnd"] != DBNull.Value ? Convert.ToDateTime(row["DateEnd"]) : (DateTime?)null,  // Użycie aliasu nadanego w SQL
                Description = row["Description"] as string ?? string.Empty,  
                Cost = Convert.ToDecimal(row["Cost"]),
                IsActive = Convert.ToBoolean(row["Status"])  
            };
        }
    }
}
