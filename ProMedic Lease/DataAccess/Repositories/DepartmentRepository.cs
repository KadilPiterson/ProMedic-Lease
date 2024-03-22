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
    public class DepartmentRepository : IRepository<Department>
    {
        private readonly DatabaseManager _databaseManager;

        public DepartmentRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void Add(Department department)
        {
            string query = "INSERT INTO tbl_dzialy (nazwa) VALUES (@Name);";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Name", department.Name)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public Department GetById(long id)
        {
            string query = "SELECT * FROM tbl_dzialy WHERE id = @Id";
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
            return new Department
            {
                Id = Convert.ToInt64(row["id"]),
                Name = row["nazwa"].ToString()
            };
        }

        public IEnumerable<Department> GetAll()
        {
            List<Department> departments = new List<Department>();
            string query = "SELECT * FROM tbl_dzialy";

            var dataTable = _databaseManager.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                departments.Add(new Department
                {
                    Id = Convert.ToInt64(row["id"]),
                    Name = row["nazwa"].ToString()
                });
            }

            return departments;
        }

        public void Update(Department department)
        {
            string query = "UPDATE tbl_dzialy SET nazwa = @Name WHERE id = @Id;";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", department.Id),
            new SqlParameter("@Name", department.Name)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = "DELETE FROM tbl_dzialy WHERE id = @Id;";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", id)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }
    }
}