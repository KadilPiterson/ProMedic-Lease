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
    public class EmploymentFormRepository : IEmploymentFormRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public EmploymentFormRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["EmploymentForm"];
        }

        public void Add(EmploymentForm employmentForm)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(employmentForm);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.EmploymentForms.Remove(employmentForm.Id);
        }

        public EmploymentForm GetById(long id)
        {
            var cached = Cache.EmploymentForms.Get(id);
            if (cached != null)
            {
                return cached;
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<EmploymentForm> GetAll()
        {
            Cache.EmploymentForms.Clear();
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(EmploymentForm employmentForm)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(employmentForm, true);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.EmploymentForms.Update(employmentForm.Id, employmentForm);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.EmploymentForms.Remove(id);
        }

        private SqlParameter[] BuildParameters(EmploymentForm employmentForm, bool includeId = false)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", employmentForm.Name)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@Id", employmentForm.Id));
            }

            return parameters.ToArray();
        }

        private EmploymentForm MapFromDataRow(DataRow row)
        {
            long formId = Convert.ToInt64(row["id"]);
            return Cache.EmploymentForms.GetOrCreate(formId, () => Create(row));
        }

        private EmploymentForm Create(DataRow row)
        {
            return new EmploymentForm
            {
                Id = Convert.ToInt64(row["id"]),
                Name = row["nazwa"] as string ?? string.Empty
            };
        }
    }
}
