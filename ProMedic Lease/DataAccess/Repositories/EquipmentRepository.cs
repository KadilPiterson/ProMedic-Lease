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

        public EquipmentRepository(DatabaseManager databaseManager)
        {
            _databaseManager = databaseManager;
        }

        public void Add(Equipment equipment)
        {
            string query = @"
            INSERT INTO tbl_sprzet (nazwa, numer_inwentarzowy, data_zakupu, numer_faktury, numer_identyfikacyjny, czy_serwis, czy_w_drodze, data_likwidacji, status, typ_sprzetu_id, cena_za_dzien)
            VALUES (@Name, @InventoryNumber, @PurchaseDate, @InvoiceNumber, @IdentificationNumber, @IsServiced, @IsInTransit, @DisposalDate, @Status, @EquipmentTypeId, @DailyRentalPrice);
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Name", equipment.Name),
            new SqlParameter("@InventoryNumber", equipment.InventoryNumber),
            new SqlParameter("@PurchaseDate", equipment.PurchaseDate),
            new SqlParameter("@InvoiceNumber", equipment.InvoiceNumber),
            new SqlParameter("@IdentificationNumber", equipment.IdentificationNumber),
            new SqlParameter("@IsServiced", equipment.IsServiced),
            new SqlParameter("@IsInTransit", equipment.IsInTransit),
            new SqlParameter("@DisposalDate", (object)equipment.DisposalDate ?? DBNull.Value), // Convert nullable DateTime to DBNull if null
            new SqlParameter("@Status", equipment.Status),
            new SqlParameter("@EquipmentTypeId", equipment.EquipmentTypeId),
            new SqlParameter("@DailyRentalPrice", equipment.DailyRentalPrice)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public Equipment GetById(long id)
        {
            string query = "SELECT * FROM tbl_sprzet WHERE id = @Id";
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
            return new Equipment
            {
                Id = Convert.ToInt64(row["id"]),
                Name = row["nazwa"].ToString(),
                InventoryNumber = row["numer_inwentarzowy"].ToString(),
                PurchaseDate = Convert.ToDateTime(row["data_zakupu"]),
                InvoiceNumber = row["numer_faktury"].ToString(),
                IdentificationNumber = row["numer_identyfikacyjny"].ToString(),
                IsServiced = Convert.ToBoolean(row["czy_serwis"]),
                IsInTransit = Convert.ToBoolean(row["czy_w_drodze"]),
                DisposalDate = row["data_likwidacji"] == DBNull.Value ? null : Convert.ToDateTime(row["data_likwidacji"]),
                Status = Convert.ToInt32(row["status"]),
                EquipmentTypeId = Convert.ToInt64(row["typ_sprzetu_id"]),
                DailyRentalPrice = Convert.ToDecimal(row["cena_za_dzien"])
            };
        }

        public IEnumerable<Equipment> GetAll()
        {
            List<Equipment> equipmentList = new List<Equipment>();
            string query = "SELECT * FROM tbl_sprzet";

            var dataTable = _databaseManager.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                equipmentList.Add(new Equipment
                {
                    Id = Convert.ToInt64(row["id"]),
                    Name = row["nazwa"].ToString(),
                    InventoryNumber = row["numer_inwentarzowy"].ToString(),
                    PurchaseDate = Convert.ToDateTime(row["data_zakupu"]),
                    InvoiceNumber = row["numer_faktury"].ToString(),
                    IdentificationNumber = row["numer_identyfikacyjny"].ToString(),
                    IsServiced = Convert.ToBoolean(row["czy_serwis"]),
                    IsInTransit = Convert.ToBoolean(row["czy_w_drodze"]),
                    DisposalDate = row["data_likwidacji"] == DBNull.Value ? null : Convert.ToDateTime(row["data_likwidacji"]),
                    Status = Convert.ToInt32(row["status"]),
                    EquipmentTypeId = Convert.ToInt64(row["typ_sprzetu_id"]),
                    DailyRentalPrice = Convert.ToDecimal(row["cena_za_dzien"])
                });
            }

            return equipmentList;
        }

        public void Update(Equipment equipment)
        {
            string query = @"
            UPDATE tbl_sprzet 
            SET nazwa = @Name, 
                numer_inwentarzowy = @InventoryNumber, 
                data_zakupu = @PurchaseDate, 
                numer_faktury = @InvoiceNumber, 
                numer_identyfikacyjny = @IdentificationNumber, 
                czy_serwis = @IsServiced, 
                czy_w_drodze = @IsInTransit, 
                data_likwidacji = @DisposalDate, 
                status = @Status, 
                typ_sprzetu_id = @EquipmentTypeId, 
                cena_za_dzien = @DailyRentalPrice
            WHERE id = @Id;
        ";

            SqlParameter[] parameters = new SqlParameter[]
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
            new SqlParameter("@EquipmentTypeId", equipment.EquipmentTypeId),
            new SqlParameter("@DailyRentalPrice", equipment.DailyRentalPrice)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }

        public void Delete(long id)
        {
            string query = "DELETE FROM tbl_sprzet WHERE id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };

            _databaseManager.ExecuteNonQuery(query, parameters);
        }
    }
}