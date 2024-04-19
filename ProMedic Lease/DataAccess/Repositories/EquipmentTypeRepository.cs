using ProMedic_Lease.Models;
using ProMedic_Lease.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProMedic_Lease.DataAccess.Repositories.Interfaces;

namespace ProMedic_Lease.DataAccess.Repositories
{
    public class EquipmentTypeRepository : IEquipmentTypeRepository
    {
        private readonly DatabaseManager _databaseManager;

        public EquipmentTypeRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void Add(EquipmentType equipmentType)
        {
            string query = @"
            INSERT INTO tbl_typ_sprzetu (nazwa, opis)
            VALUES (@Name, @Description);
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Name", equipmentType.Name),
            new SqlParameter("@Description", equipmentType.Description)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public EquipmentType GetById(long id)
        {
            string query = "SELECT * FROM tbl_typ_sprzetu WHERE id = @Id";
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
            return new EquipmentType
            {
                Id = Convert.ToInt64(row["id"]),
                Name = row["nazwa"].ToString(),
                Description = row["opis"].ToString()
            };
        }

        public IEnumerable<EquipmentType> GetAll()
        {
            List<EquipmentType> equipmentTypes = new List<EquipmentType>();
            string query = "SELECT * FROM tbl_typ_sprzetu";

            var dataTable = _databaseManager.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                equipmentTypes.Add(new EquipmentType
                {
                    Id = Convert.ToInt64(row["id"]),
                    Name = row["nazwa"].ToString(),
                    Description = row["opis"].ToString()
                });
            }

            return equipmentTypes;
        }

        public void Update(EquipmentType equipmentType)
        {
            string query = @"
            UPDATE tbl_typ_sprzetu 
            SET nazwa = @Name, opis = @Description 
            WHERE id = @Id;
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", equipmentType.Id),
            new SqlParameter("@Name", equipmentType.Name),
            new SqlParameter("@Description", equipmentType.Description)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = "DELETE FROM tbl_typ_sprzetu WHERE id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", id)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }
    }
}
