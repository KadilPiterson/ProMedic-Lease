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
    public class ClientRepository : IClientRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _queries;

        public ClientRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _queries = QueryConfig.Instance.Queries["Client"];
        }

        public void Add(Client client)
        {
            string query = _queries["Add"];
            SqlParameter[] parameters = BuildParameters(client);
            _databaseManager.ExecuteNonQuery(query, parameters);
            var cached = Cache.ClientsCache.Get(client.Id);
            if (cached != null)
            {
                Cache.ClientsCache.Remove(cached.Id);
            }
            Cache.ClientsCache.Add(client.Id, client);

        }

        public Client GetById(long id)
        {
            var cached = Cache.ClientsCache.Get(id);
            if (cached != null)
            {
                Cache.ClientsCache.Remove(cached.Id);
            }

            string query = _queries["GetById"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            return dataTable.Rows.Count == 0 ? null : MapFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<Client> GetAll()
        {
            Cache.ClientsCache.Clear();
            string query = _queries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapFromDataRow(row)).ToList();
        }

        public void Update(Client client)
        {
            string query = _queries["Update"];
            SqlParameter[] parameters = BuildParameters(client, true);
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.ClientsCache.Update(client.Id, client);
        }

        public void Delete(long id)
        {
            string query = _queries["Delete"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
            Cache.ClientsCache.Remove(id);
        }

        private SqlParameter[] BuildParameters(Client client, bool includeId = false)
        {
            var parameters = new List<SqlParameter>
            {
                new SqlParameter("@FirstName", client.FirstName),
                new SqlParameter("@LastName", client.LastName),
                new SqlParameter("@PESEL", client.Pesel),
                new SqlParameter("@Street", client.Street),
                new SqlParameter("@HouseNumber", client.HouseNumber),
                new SqlParameter("@ApartmentNumber", client.ApartmentNumber),
                new SqlParameter("@PostalCode", client.PostalCode),
                new SqlParameter("@City", client.City),
                new SqlParameter("@Email", client.Email),
                new SqlParameter("@Phone", client.Phone)
            };

            if (includeId)
            {
                parameters.Add(new SqlParameter("@Id", client.Id));
            }

            return parameters.ToArray();
        }

        private Client MapFromDataRow(DataRow row)
        {
            long clientId = Convert.ToInt64(row["id"]);
            return Cache.ClientsCache.GetOrCreate(clientId, () => Create(row));
        }

        private Client Create(DataRow row)
        {
            return new Client
            {
                Id = Convert.ToInt64(row["id"]),
                FirstName = row["FirstName"] as string ?? string.Empty,
                LastName = row["LastName"] as string ?? string.Empty,
                Pesel = row["PESEL"] as string ?? string.Empty,
                Street = row["Street"] as string ?? string.Empty,
                HouseNumber = row["HouseNumber"] as string ?? string.Empty,
                ApartmentNumber = row["ApartmentNumber"] as string ?? string.Empty,
                PostalCode = row["PostalCode"] as string ?? string.Empty,
                City = row["City"] as string ?? string.Empty,
                Email = row["Email"] as string ?? string.Empty,
                Phone = row["Phone"] as string ?? string.Empty
            };
        }
    }
}