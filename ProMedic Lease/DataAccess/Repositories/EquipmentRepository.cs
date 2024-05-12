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
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public EquipmentRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["Equipment"];
        }

        public void Add(Equipment equipment)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(equipment);
            _databaseManager.ExecuteNonQuery(query, parameters);
            var cached = Cache.Equipments.Get(equipment.Id);
            if (cached != null)
            {
                Cache.Equipments.Remove(cached.Id);
            }
            Cache.Equipments.Add(equipment.Id, equipment);
        }

        public Equipment GetById(long id)
        {
            var cached = Cache.Equipments.Get(id);
            if (cached != null)
            {
                Cache.Equipments.Remove(cached.Id);
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<Equipment> GetAll()
        {
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(Equipment equipment)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(equipment);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Equipments.Update(equipment.Id, equipment);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Equipments.Remove(id);
        }

        private SqlParameter[] BuildParameters(Equipment equipment)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@Id", equipment.Id),
                new SqlParameter("@Name", equipment.Name),
                new SqlParameter("@InventoryNumber", equipment.InventoryNumber),
                new SqlParameter("@PurchaseDate", equipment.PurchaseDate),
                new SqlParameter("@InvoiceNumber", equipment.InvoiceNumber),
                new SqlParameter("@IdentificationNumber", equipment.IdentificationNumber),
                new SqlParameter("@IsServiced", equipment.IsServiced),
                new SqlParameter("@IsInTransit", equipment.IsInTransit),
                new SqlParameter("@DisposalDate", (object)equipment.DisposalDate ?? DBNull.Value),
                new SqlParameter("@Status", equipment.IsActive),
                new SqlParameter("@EquipmentTypeId", equipment.EquipmentType.Id),
                new SqlParameter("@DailyRentalPrice", equipment.DailyRentalPrice)
            };
        }

        private Equipment MapFromDataRow(DataRow row)
        {
            long id = Convert.ToInt64(row["EquipmentId"]);
            return Cache.Equipments.GetOrCreate(id, () => Create(row));
        }


        private Equipment Create(DataRow row)
        {
            return new Equipment
            {
                Id = Convert.ToInt64(row["EquipmentId"]),
                Name = Convert.ToString(row["EquipmentName"]) ?? string.Empty,
                InventoryNumber = Convert.ToString(row["InventoryNumber"]) ?? string.Empty,
                PurchaseDate = Convert.ToDateTime(row["PurchaseDate"]),
                InvoiceNumber = Convert.ToString(row["InvoiceNumber"]) ?? string.Empty,
                IdentificationNumber = Convert.ToString(row["IdentificationNumber"]) ?? string.Empty,
                IsServiced = Convert.ToBoolean(row["IsServiced"]),
                IsInTransit = Convert.ToBoolean(row["IsInTransit"]),
                DisposalDate = row["DisposalDate"] == DBNull.Value ? null : Convert.ToDateTime(row["DisposalDate"]),
                IsActive = Convert.ToBoolean(row["EquipmentStatus"]),
                EquipmentType = Cache.EquipmentTypes.GetOrCreate(Convert.ToInt64(row["TypeId"]), () => new EquipmentType
                {
                    Id = Convert.ToInt64(row["TypeId"]),
                    Name = Convert.ToString(row["TypeName"]) ?? string.Empty,
                    Description = Convert.ToString(row["TypeDescription"]) ?? string.Empty
                }),
                DailyRentalPrice = Convert.ToDecimal(row["DailyRentalPrice"])
            };
        }
    }
}