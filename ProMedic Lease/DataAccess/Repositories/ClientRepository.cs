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
    public class ClientRepository : IClientRepository
    {
        private readonly DatabaseManager _databaseManager;
        private readonly Dictionary<string, string> _clientQueries;

        public ClientRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
            _clientQueries = QueryConfig.Instance.Queries["Client"];
        }

        public void Add(Client client)
        {
            string query = _clientQueries["Add"];
            SqlParameter[] parameters = {
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
            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public Client GetById(long id)
        {
            string query = _clientQueries["GetById"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            if (dataTable.Rows.Count == 0) return null;
            return MapClientFromDataRow(dataTable.Rows[0]);
        }

        public IEnumerable<Client> GetAll()
        {
            string query = _clientQueries["GetAll"];
            var dataTable = _databaseManager.ExecuteQuery(query);
            return dataTable.AsEnumerable().Select(row => MapClientFromDataRow(row)).ToList();
        }

        public void Update(Client client)
        {
            string query = _clientQueries["Update"];
            SqlParameter[] parameters = {
                new SqlParameter("@Id", client.Id),
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
            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = _clientQueries["Delete"];
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        private Client MapClientFromDataRow(DataRow row)
        {
            return new Client
            {
                Id = (long)row["id"],
                FirstName = (string)row["FirstName"],
                LastName = (string)row["LastName"],
                Pesel = (string)row["PESEL"],
                Street = (string)row["Street"],
                HouseNumber = (string)row["HouseNumber"],
                ApartmentNumber = (string)row["ApartmentNumber"],
                PostalCode = (string)row["PostalCode"],
                City = (string)row["City"],
                Email = (string)row["Email"],
                Phone = (string)row["Phone"]
            };
        }
    }
}