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
    public class ClientRepository : IRepository<Client>
    {
        private readonly DatabaseManager _databaseManager;

        public ClientRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void Add(Client client)
        {
            string query = @"
            INSERT INTO tbl_klient (imie, nazwisko, pesel, ulica, nr_domu, lokal, kod_pocztowy, miejscowosc, email, numer_telefonu)
            VALUES (@FirstName, @LastName, @PESEL, @Street, @HouseNumber, @ApartmentNumber, @PostalCode, @City, @Email, @PhoneNumber);
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FirstName", client.FirstName),
            new SqlParameter("@LastName", client.LastName),
            new SqlParameter("@PESEL", client.PESEL),
            new SqlParameter("@Street", client.Street),
            new SqlParameter("@HouseNumber", client.HouseNumber),
            new SqlParameter("@ApartmentNumber", client.ApartmentNumber),
            new SqlParameter("@PostalCode", client.PostalCode),
            new SqlParameter("@City", client.City),
            new SqlParameter("@Email", client.Email),
            new SqlParameter("@PhoneNumber", client.PhoneNumber),
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public Client GetById(long id)
        {
            string query = "SELECT * FROM tbl_klient WHERE id = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };

            var dataTable = _databaseManager.ExecuteQuery(query, parameters);
            if (dataTable.Rows.Count == 0) return null;

            var row = dataTable.Rows[0];
            return new Client
            {
                Id = (long)row["id"],
                FirstName = (string)row["imie"],
                LastName = (string)row["nazwisko"],
                PESEL = (string)row["pesel"],
                Street = (string)row["ulica"],
                HouseNumber = (string)row["nr_domu"],
                ApartmentNumber = (string)row["lokal"],
                PostalCode = (string)row["kod_pocztowy"],
                City = (string)row["miejscowosc"],
                Email = (string)row["email"],
                PhoneNumber = (string)row["numer_telefonu"],
            };
        }

        public IEnumerable<Client> GetAll()
        {
            List<Client> clients = new List<Client>();
            string query = "SELECT * FROM tbl_klient";

            var dataTable = _databaseManager.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                clients.Add(new Client
                {
                    Id = Convert.ToInt64(row["id"]),
                    FirstName = row["imie"].ToString(),
                    LastName = row["nazwisko"].ToString(),
                    PESEL = row["pesel"].ToString(),
                    Street = row["ulica"].ToString(),
                    HouseNumber = row["nr_domu"].ToString(),
                    ApartmentNumber = row["lokal"].ToString(),
                    PostalCode = row["kod_pocztowy"].ToString(),
                    City = row["miejscowosc"].ToString(),
                    Email = row["email"].ToString(),
                    PhoneNumber = row["numer_telefonu"].ToString(),
                });
            }

            return clients;
        }

        public void Update(Client client)
        {
            string query = @"
            UPDATE tbl_klient SET 
            imie = @FirstName, 
            nazwisko = @LastName, 
            pesel = @PESEL, 
            ulica = @Street, 
            nr_domu = @HouseNumber, 
            lokal = @ApartmentNumber, 
            kod_pocztowy = @PostalCode, 
            miejscowosc = @City, 
            email = @Email, 
            numer_telefonu = @PhoneNumber
            WHERE id = @Id;
            ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", client.Id),
                new SqlParameter("@FirstName", client.FirstName),
                new SqlParameter("@LastName", client.LastName),
                new SqlParameter("@PESEL", client.PESEL),
                new SqlParameter("@Street", client.Street),
                new SqlParameter("@HouseNumber", client.HouseNumber),
                new SqlParameter("@ApartmentNumber", client.ApartmentNumber),
                new SqlParameter("@PostalCode", client.PostalCode),
                new SqlParameter("@City", client.City),
                new SqlParameter("@Email", client.Email),
                new SqlParameter("@PhoneNumber", client.PhoneNumber),
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = "DELETE FROM tbl_klient WHERE id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }
    }
}
