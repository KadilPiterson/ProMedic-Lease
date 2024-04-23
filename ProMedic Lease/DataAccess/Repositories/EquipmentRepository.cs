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
            var cached = Cache.EquipmentsCache.Get(equipment.Id);
            if (cached != null)
            {
                Cache.EquipmentsCache.Remove(cached.Id);
            }
            Cache.EquipmentsCache.Add(cached.Id, cached);
        }

        public Equipment GetById(long id)
        {
            var cached = Cache.EquipmentsCache.Get(id);
            if (cached != null)
            {
                Cache.EquipmentsCache.Remove(cached.Id);
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
            Cache.EquipmentsCache.Update(equipment.Id, equipment);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.EquipmentsCache.Remove(id);
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
                new SqlParameter("@Status", equipment.Status),
                new SqlParameter("@EquipmentTypeId", equipment.EquipmentType.Id),
                new SqlParameter("@DailyRentalPrice", equipment.DailyRentalPrice)
            };
        }

        private Equipment MapFromDataRow(DataRow row)
        {
            long id = Convert.ToInt64(row["id"]);
            return Cache.EquipmentsCache.GetOrCreate(id, () => Create(row));
        }


        private Equipment Create(DataRow row)
        {
            return new Equipment
            {
                Id = Convert.ToInt64(row["id"]),
                Name = row["nazwa"] as string ?? string.Empty,
                InventoryNumber = row["numer_inwentarzowy"] as string ?? string.Empty,
                PurchaseDate = Convert.ToDateTime(row["data_zakupu"]),
                InvoiceNumber = row["numer_faktury"] as string ?? string.Empty,
                IdentificationNumber = row["numer_identyfikacyjny"] as string ?? string.Empty,
                IsServiced = Convert.ToBoolean(row["czy_serwis"]),
                IsInTransit = Convert.ToBoolean(row["czy_w_drodze"]),
                DisposalDate = row["data_likwidacji"] == DBNull.Value ? null : Convert.ToDateTime(row["data_likwidacji"]),
                Status = Convert.ToInt32(row["status"]),
                EquipmentType = Cache.EquipmentTypesCache.GetOrCreate(Convert.ToInt64(row["typ_sprzetu_id"]), () => new EquipmentType
                {
                    Id = Convert.ToInt64(row["typ_sprzetu_id"]),
                    Name = row["typ_sprzetu_nazwa"] as string ?? string.Empty,
                    Description = row["typ_sprzetu_opis"] as string ?? string.Empty
                }),
                DailyRentalPrice = Convert.ToDecimal(row["cena_za_dzien"])
            };
        }
    }
}