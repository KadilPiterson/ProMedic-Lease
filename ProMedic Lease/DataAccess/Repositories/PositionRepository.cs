using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Utilities;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.DataAccess.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public PositionRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["Position"];
        }

        public void Add(Position position)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(position);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Positions.Remove(position.Id);
        }

        public Position GetById(long id)
        {
            var cached = Cache.Positions.Get(id);
            if (cached != null)
            {
                return cached;
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<Position> GetAll()
        {
            Cache.Positions.Clear();
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(Position position)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(position, true);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Positions.Update(position.Id, position);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.Positions.Remove(id); 
        }

        private SqlParameter[] BuildParameters(Position position, bool includeId = false)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@Name", position.Name)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@Id", position.Id));
            }

            return parameters.ToArray();
        }

        private Position MapFromDataRow(DataRow row)
        {
            long positionId = Convert.ToInt64(row["id"]);
            return Cache.Positions.GetOrCreate(positionId, () => Create(row));
        }

        private Position Create(DataRow row)
        {
            return new Position
            {
                Id = Convert.ToInt64(row["id"]),
                Name = row["nazwa"] as string ?? string.Empty
            };
        }
    }
}
