using ProMedic_Lease.Models;
using ProMedic_Lease.Utilities;
using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ProMedic_Lease.DataAccess.Repositories
{
    public class EquipmentTypeRepository : IEquipmentTypeRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public EquipmentTypeRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["EquipmentType"];
        }

        public void Add(EquipmentType equipmentType)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(equipmentType);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.EquipmentTypes.Remove(equipmentType.Id);
        }

        public EquipmentType GetById(long id)
        {
            var cached = Cache.EquipmentTypes.Get(id);
            if (cached != null)
            {
                return cached;
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<EquipmentType> GetAll()
        {
            Cache.EquipmentTypes.Clear();
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(EquipmentType equipmentType)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(equipmentType, true);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.EquipmentTypes.Update(equipmentType.Id, equipmentType);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.EquipmentTypes.Remove(id);
        }

        private SqlParameter[] BuildParameters(EquipmentType equipmentType, bool includeId = false)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", equipmentType.Name),
                new SqlParameter("@Description", equipmentType.Description)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@Id", equipmentType.Id));
            }

            return parameters.ToArray();
        }

        private EquipmentType MapFromDataRow(DataRow row)
        {
            long typeId = Convert.ToInt64(row["id"]);
            return Cache.EquipmentTypes.GetOrCreate(typeId, () => Create(row));
        }

        private EquipmentType Create(DataRow row)
        {
            return new EquipmentType
            {
                Id = Convert.ToInt64(row["id"]),
                Name = row["nazwa"] as string ?? string.Empty,
                Description = row["opis"] as string ?? string.Empty
            };
        }
    }
}
