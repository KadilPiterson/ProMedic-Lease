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

namespace ProMedic_Lease.DataAccess.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public DepartmentRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["Department"];
        }

        public void Add(Department department)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(department);
            _databaseManager.ExecuteNonQuery(query, parameters);
            var cached = Cache.Departments.Get(department.Id);
            if (cached != null)
            {
                Cache.Departments.Remove(cached.Id);
            }
            Cache.Departments.Add(department.Id, department);
        }

        public Department GetById(long id)
        {
            var cached = Cache.Departments.Get(id);
            if (cached != null)
            {
                Cache.Departments.Remove(cached.Id);
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<Department> GetAll()
        {
            Cache.Departments.Clear();
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(Department department)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(department, true);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Departments.Update(department.Id, department);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Departments.Remove(id);
        }

        private SqlParameter[] BuildParameters(Department department, bool includeId = false)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", department.Name)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@Id", department.Id));
            }

            return parameters.ToArray();
        }

        private Department MapFromDataRow(DataRow row)
        {
            long departmentId = Convert.ToInt64(row["id"]);
            return Cache.Departments.GetOrCreate(departmentId, () => Create(row));
        }

        private Department Create(DataRow row)
        {
            return new Department
            {
                Id = Convert.ToInt64(row["id"]),
                Name = row["nazwa"] as string ?? string.Empty
            };
        }
    }
}
