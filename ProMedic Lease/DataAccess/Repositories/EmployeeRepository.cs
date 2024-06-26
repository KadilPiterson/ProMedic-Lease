﻿using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

namespace ProMedic_Lease.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public EmployeeRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["Employee"];
        }

        public void Add(Employee employee)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(employee);
            _databaseManager.ExecuteNonQuery(query, parameters);
            var cached = Cache.Employees.Get(employee.Id);
            if (cached != null)
            {
                Cache.Employees.Remove(cached.Id);
            }
            Cache.Employees.Add(employee.Id, employee);
        }

        public Employee GetById(long id)
        {
            var cached = Cache.Employees.Get(id);
            if (cached != null)
            {
                Cache.Employees.Remove(cached.Id);
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<Employee> GetAll()
        {
            Cache.Employees.Clear();
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(Employee employee)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(employee, includeId: true);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Employees.Update(employee.Id, employee);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Employees.Remove(id);
        }

        private SqlParameter[] BuildParameters(Employee employee, bool includeId = false)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@FirstName", employee.FirstName),
                new SqlParameter("@LastName", employee.LastName),
                new SqlParameter("@IsActive", employee.IsActive),
                new SqlParameter("@Email", employee.Email),
                new SqlParameter("@Phone", employee.Phone),
                new SqlParameter("@Pesel", employee.Pesel),
                new SqlParameter("@Street", employee.Street),
                new SqlParameter("@HouseNumber", employee.HouseNumber),
                new SqlParameter("@ApartmentNumber", employee.ApartmentNumber),
                new SqlParameter("@PostalCode", employee.PostalCode),
                new SqlParameter("@City", employee.City),
                new SqlParameter("@EmploymentDate", employee.EmploymentDate),
                new SqlParameter("@TerminationDate", employee.TerminationDate ?? (object)DBNull.Value),
                new SqlParameter("@Salary", employee.Salary),
                new SqlParameter("@DepartmentId", employee.Department.Id),
                new SqlParameter("@PositionId", employee.Position.Id)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@Id", employee.Id));
            }

            return parameters.ToArray();
        }

        private Employee MapFromDataRow(DataRow row)
        {
            long employeeId = Convert.ToInt64(row["id"]);
            return Cache.Employees.GetOrCreate(employeeId, () => Create(row));
        }

        private Employee Create(DataRow row)
        {
            return new Employee
            {
                Id = Convert.ToInt64(row["id"]),
                FirstName = row["FirstName"] as string ?? string.Empty,
                LastName = row["LastName"] as string ?? string.Empty,
                IsActive = Convert.ToBoolean(row["IsActive"]),
                Email = row["Email"] as string ?? string.Empty,
                Phone = row["Phone"] as string ?? string.Empty,
                Pesel = row["Pesel"] as string ?? string.Empty,
                Street = row["Street"] as string ?? string.Empty,
                HouseNumber = row.Field<int>("HouseNumber"),
                ApartmentNumber = row.Field<int>("ApartmentNumber"),
                PostalCode = row["PostalCode"] as string ?? string.Empty,
                City = row["City"] as string ?? string.Empty,
                EmploymentDate = Convert.ToDateTime(row["EmploymentDate"]),
                TerminationDate = row.IsNull("TerminationDate") ? (DateTime?)null : Convert.ToDateTime(row["TerminationDate"]),
                Salary = Convert.ToDecimal(row["Salary"]),
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
            };
        }
    }
}
