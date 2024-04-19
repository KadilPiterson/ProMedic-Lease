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
    public class MaintenanceHistoryRepository : IMaintenanceHistoryRepository
    {
        private readonly DatabaseManager _databaseManager;

        public MaintenanceHistoryRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void Add(MaintenanceHistory maintenanceHistory)
        {
            string query = @"
            INSERT INTO tbl_historia_konserwacji (sprzet_id, pracownik_id, koszt, czas, data, opis)
            VALUES (@EquipmentId, @EmployeeId, @Cost, @Time, @Date, @Description);
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@EquipmentId", maintenanceHistory.EquipmentId),
            new SqlParameter("@EmployeeId", maintenanceHistory.EmployeeId),
            new SqlParameter("@Cost", maintenanceHistory.Cost),
            new SqlParameter("@Time", maintenanceHistory.Time),
            new SqlParameter("@Date", maintenanceHistory.Date),
            new SqlParameter("@Description", maintenanceHistory.Description)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public MaintenanceHistory GetById(long id)
        {
            string query = "SELECT * FROM tbl_historia_konserwacji WHERE id = @Id";
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
            return new MaintenanceHistory
            {
                Id = Convert.ToInt64(row["id"]),
                EquipmentId = Convert.ToInt64(row["sprzet_id"]),
                EmployeeId = Convert.ToInt64(row["pracownik_id"]),
                Cost = Convert.ToDecimal(row["koszt"]),
                Time = Convert.ToInt32(row["czas"]),
                Date = Convert.ToDateTime(row["data"]),
                Description = row["opis"].ToString()
            };
        }

        public IEnumerable<MaintenanceHistory> GetAll()
        {
            List<MaintenanceHistory> maintenanceHistories = new List<MaintenanceHistory>();
            string query = "SELECT * FROM tbl_historia_konserwacji";

            var dataTable = _databaseManager.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                maintenanceHistories.Add(new MaintenanceHistory
                {
                    Id = Convert.ToInt64(row["id"]),
                    EquipmentId = Convert.ToInt64(row["sprzet_id"]),
                    EmployeeId = Convert.ToInt64(row["pracownik_id"]),
                    Cost = Convert.ToDecimal(row["koszt"]),
                    Time = Convert.ToInt32(row["czas"]),
                    Date = Convert.ToDateTime(row["data"]),
                    Description = row["opis"].ToString()
                });
            }

            return maintenanceHistories;
        }

        public void Update(MaintenanceHistory maintenanceHistory)
        {
            string query = @"
            UPDATE tbl_historia_konserwacji 
            SET sprzet_id = @EquipmentId, 
                pracownik_id = @EmployeeId, 
                koszt = @Cost, 
                czas = @Time, 
                data = @Date, 
                opis = @Description
            WHERE id = @Id;
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", maintenanceHistory.Id),
            new SqlParameter("@EquipmentId", maintenanceHistory.EquipmentId),
            new SqlParameter("@EmployeeId", maintenanceHistory.EmployeeId),
            new SqlParameter("@Cost", maintenanceHistory.Cost),
            new SqlParameter("@Time", maintenanceHistory.Time),
            new SqlParameter("@Date", maintenanceHistory.Date),
            new SqlParameter("@Description", maintenanceHistory.Description)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = "DELETE FROM tbl_historia_konserwacji WHERE id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", id)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }
    }
}
