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
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly DatabaseManager _databaseManager;

        public EmployeeRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void Add(Employee employee)
        {
            string query = @"
            INSERT INTO tbl_pracownicy (imie, nazwisko, username, password_salt, password_hash, role, activation_code, active, email, telefon, pesel, ulica, nr_domu, lokal, kod_pocztowy, miejscowosc, data_zatrudnienia, data_zwolnienia, zarobek, dzial_id, stanowisko_id)
            VALUES (@FirstName, @LastName, @Username, @PasswordSalt, @PasswordHash, @Role, @ActivationCode, @IsActive, @Email, @Phone, @Pesel, @Street, @HouseNumber, @ApartmentNumber, @PostalCode, @City, @EmploymentDate, @TerminationDate, @Salary, @DepartmentId, @PositionId);
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@FirstName", employee.FirstName),
            new SqlParameter("@LastName", employee.LastName),
            new SqlParameter("@Username", employee.Username),
            new SqlParameter("@PasswordSalt", employee.PasswordSalt),
            new SqlParameter("@PasswordHash", employee.PasswordHash),
            new SqlParameter("@Role", employee.Role),
            new SqlParameter("@ActivationCode", employee.ActivationCode),
            new SqlParameter("@IsActive", employee.IsActive),
            new SqlParameter("@Email", employee.Email),
            new SqlParameter("@Phone", employee.Phone),
            new SqlParameter("@Pesel", employee.Pesel),
            new SqlParameter("@Street", employee.Street),
            new SqlParameter("@HouseNumber", employee.HouseNumber),
            new SqlParameter("@ApartmentNumber", employee.ApartmentNumber),
            new SqlParameter("@PostalCode", employee.PostalCode),
            new SqlParameter("@City", employee.City),
            new SqlParameter("@EmploymentDate", employee.EmploymentDate),
            new SqlParameter("@TerminationDate", (object)employee.TerminationDate ?? DBNull.Value), // Convert nullable DateTime to DBNull if null
            new SqlParameter("@Salary", employee.Salary),
            new SqlParameter("@DepartmentId", employee.Department.Id),
            new SqlParameter("@PositionId", employee.Position.Id)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public Employee GetById(long id)
        {
            string query = "SELECT * FROM tbl_pracownicy WHERE id = @Id";
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
            return new Employee
            {
                Id = Convert.ToInt64(row["id"]),
                FirstName = row["imie"].ToString(),
                LastName = row["nazwisko"].ToString(),
                Username = row["username"].ToString(),
                PasswordSalt = row["password_salt"].ToString(),
                PasswordHash = row["password_hash"].ToString(),
                Role = row["role"].ToString(),
                ActivationCode = row["activation_code"].ToString(),
                IsActive = Convert.ToBoolean(row["active"]),
                Email = row["email"].ToString(),
                Phone = row["telefon"].ToString(),
                Pesel = row["pesel"].ToString(),
                Street = row["ulica"].ToString(),
                HouseNumber = row["nr_domu"].ToString(),
                ApartmentNumber = row["lokal"].ToString(),
                PostalCode = row["kod_pocztowy"].ToString(),
                City = row["miejscowosc"].ToString(),
                EmploymentDate = Convert.ToDateTime(row["data_zatrudnienia"]),
                TerminationDate = row["data_zwolnienia"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["data_zwolnienia"]),
                Salary = Convert.ToDecimal(row["zarobek"]),
                Department = new Department { Id = Convert.ToInt64(row["dzial_id"]) },
                Position = new Position { Id = Convert.ToInt64(row["stanowisko_id"]) }
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            List<Employee> employeeList = new List<Employee>();
            string query = "SELECT * FROM tbl_pracownicy";

            var dataTable = _databaseManager.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                employeeList.Add(new Employee
                {
                    Id = Convert.ToInt64(row["id"]),
                    FirstName = row["imie"].ToString(),
                    LastName = row["nazwisko"].ToString(),
                    Username = row["username"].ToString(),
                    PasswordSalt = row["password_salt"].ToString(),
                    PasswordHash = row["password_hash"].ToString(),
                    Role = row["role"].ToString(),
                    ActivationCode = row["activation_code"].ToString(),
                    IsActive = Convert.ToBoolean(row["active"]),
                    Email = row["email"].ToString(),
                    Phone = row["telefon"].ToString(),
                    Pesel = row["pesel"].ToString(),
                    Street = row["ulica"].ToString(),
                    HouseNumber = row["nr_domu"].ToString(),
                    ApartmentNumber = row["lokal"].ToString(),
                    PostalCode = row["kod_pocztowy"].ToString(),
                    City = row["miejscowosc"].ToString(),
                    EmploymentDate = Convert.ToDateTime(row["data_zatrudnienia"]),
                    TerminationDate = row["data_zwolnienia"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["data_zwolnienia"]),
                    Salary = Convert.ToDecimal(row["zarobek"]),
                    Department = new Department { Id = Convert.ToInt64(row["dzial_id"]) },
                    Position = new Position { Id = Convert.ToInt64(row["stanowisko_id"]) }
                });
            }

            return employeeList;
        }

        public void Update(Employee employee)
        {
            string query = @"
            UPDATE tbl_pracownicy 
            SET imie = @FirstName, 
                nazwisko = @LastName, 
                username = @Username, 
                password_salt = @PasswordSalt, 
                password_hash = @PasswordHash, 
                role = @Role, 
                activation_code = @ActivationCode, 
                active = @IsActive, 
                email = @Email, 
                telefon = @Phone, 
                pesel = @Pesel, 
                ulica = @Street, 
                nr_domu = @HouseNumber, 
                lokal = @ApartmentNumber, 
                kod_pocztowy = @PostalCode, 
                miejscowosc = @City, 
                data_zatrudnienia = @EmploymentDate, 
                data_zwolnienia = @TerminationDate, 
                zarobek = @Salary, 
                dzial_id = @DepartmentId, 
                stanowisko_id = @PositionId
            WHERE id = @Id;
            ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", employee.Id),
            new SqlParameter("@FirstName", employee.FirstName),
            new SqlParameter("@LastName", employee.LastName),
            new SqlParameter("@Username", employee.Username),
            new SqlParameter("@PasswordSalt", employee.PasswordSalt),
            new SqlParameter("@PasswordHash", employee.PasswordHash),
            new SqlParameter("@Role", employee.Role),
            new SqlParameter("@ActivationCode", employee.ActivationCode),
            new SqlParameter("@IsActive", employee.IsActive),
            new SqlParameter("@Email", employee.Email),
            new SqlParameter("@Phone", employee.Phone),
            new SqlParameter("@Pesel", employee.Pesel),
            new SqlParameter("@Street", employee.Street),
            new SqlParameter("@HouseNumber", employee.HouseNumber),
            new SqlParameter("@ApartmentNumber", employee.ApartmentNumber),
            new SqlParameter("@PostalCode", employee.PostalCode),
            new SqlParameter("@City", employee.City),
            new SqlParameter("@EmploymentDate", employee.EmploymentDate),
            new SqlParameter("@TerminationDate", (object)employee.TerminationDate ?? DBNull.Value),
            new SqlParameter("@Salary", employee.Salary),
            new SqlParameter("@DepartmentId", employee.Department),
            new SqlParameter("@PositionId", employee.Position)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = "DELETE FROM tbl_pracownicy WHERE id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Id", id)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }
    }
}
