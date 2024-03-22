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
    public class RentalRepository : IRepository<Rental>
    {
        private readonly DatabaseManager _databaseManager;

        public RentalRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void Add(Rental rental)
        {
            string query = @"
            INSERT INTO tbl_wypozyczenie (sprzet_id, data_start, data_koniec, klient_id, pracownik_id, uwagi, status)
            VALUES (@EquipmentId, @StartDate, @EndDate, @ClientId, @EmployeeId, @Comments, @Status);
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EquipmentId", rental.Equipment.Id),
                new SqlParameter("@StartDate", rental.StartDate),
                new SqlParameter("@EndDate", rental.EndDate),
                new SqlParameter("@ClientId", rental.Client.Id),
                new SqlParameter("@EmployeeId", rental.Employee.Id),
                new SqlParameter("@Comments", rental.Comments),
                new SqlParameter("@Status", rental.Status)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public Rental GetById(long id)
        {
            string query = "SELECT * FROM tbl_wypozyczenie WHERE id = @Id";
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
            return new Rental
            {
                Id = Convert.ToInt64(row["id"]),
                Equipment = new Equipment { Id = Convert.ToInt64(row["sprzet_id"]) },
                StartDate = Convert.ToDateTime(row["data_start"]),
                EndDate = Convert.ToDateTime(row["data_koniec"]),
                Client = new Client { Id = Convert.ToInt64(row["klient_id"]) },
                Employee = new Employee { Id = Convert.ToInt64(row["pracownik_id"]) },
                Comments = row["uwagi"].ToString(),
                Status = Convert.ToInt32(row["status"])
            };
        }

        public IEnumerable<Rental> GetAll()
        {
            List<Rental> rentals = new List<Rental>();
            string query = "SELECT * FROM tbl_wypozyczenie";

            var dataTable = _databaseManager.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                rentals.Add(new Rental
                {
                    Id = Convert.ToInt64(row["id"]),
                    Equipment = new Equipment { Id = Convert.ToInt64(row["sprzet_id"]) },
                    StartDate = Convert.ToDateTime(row["data_start"]),
                    EndDate = Convert.ToDateTime(row["data_koniec"]),
                    Client = new Client { Id = Convert.ToInt64(row["klient_id"]) },
                    Employee = new Employee { Id = Convert.ToInt64(row["pracownik_id"]) },
                    Comments = row["uwagi"].ToString(),
                    Status = Convert.ToInt32(row["status"])
                });
            }

            return rentals;
        }

        public void Update(Rental rental)
        {
            string query = @"
            UPDATE tbl_wypozyczenie 
            SET sprzet_id = @EquipmentId, 
                data_start = @StartDate, 
                data_koniec = @EndDate, 
                klient_id = @ClientId, 
                pracownik_id = @EmployeeId, 
                uwagi = @Comments, 
                status = @Status
            WHERE id = @Id;
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", rental.Id),
                new SqlParameter("@EquipmentId", rental.Equipment.Id),
                new SqlParameter("@StartDate", rental.StartDate),
                new SqlParameter("@EndDate", rental.EndDate),
                new SqlParameter("@ClientId", rental.Client.Id),
                new SqlParameter("@EmployeeId", rental.Employee.Id),
                new SqlParameter("@Comments", rental.Comments),
                new SqlParameter("@Status", rental.Status)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = "DELETE FROM tbl_wypozyczenie WHERE id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }
    }
}