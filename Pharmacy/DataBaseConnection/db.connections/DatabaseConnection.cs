using System;
using System.Data.SQLite;
using Pharmacy.Models;


namespace Pharmacy.DataBaseConnection
{
    public static class DatabaseConnection
    {
        private readonly static SQLiteConnection _connection =
            DatabaseConnectionManager.GetSqlConnection().OpenAndReturn();
        
        
        public static SQLiteDataReader GetMedicineIdInPharmacyWarehouse(string medicineName)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText =
                $"SELECT pharmacy_warehouse.id FROM pharmacy_warehouse join medicine m on m.id = pharmacy_warehouse.id_medicine where name='{medicineName}'";
            return command.ExecuteReader();
        }
        
        public static SQLiteDataReader GetMedicineInPharmacyWarehouse()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText =
                $"SELECT pharmacy_warehouse.id, pharmacy_warehouse.quantity, pharmacy_warehouse.current_quantity_in_stock, pharmacy_warehouse.availability, pharmacy_warehouse.price, m.name, m.image, m.description, d.date_receipt, d.supplier, mu.name, p.name FROM pharmacy_warehouse " +
                $"JOIN medicine m on pharmacy_warehouse.id_medicine = m.id " +
                $"join delivery d on d.id = pharmacy_warehouse.id_delivery " +
                $"join measure_unit mu on mu.id = m.id_measure_unit " +
                $"join producer p on p.id = m.id_producer;";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetMedicineInPharmacyWarehouse(int medicineId)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText =
                $"SELECT pharmacy_warehouse.id, pharmacy_warehouse.quantity, pharmacy_warehouse.current_quantity_in_stock, pharmacy_warehouse.availability, pharmacy_warehouse.price, m.name, m.image, m.description, d.date_receipt, d.supplier, mu.name, p.name FROM pharmacy_warehouse " +
                $"JOIN medicine m on pharmacy_warehouse.id_medicine = m.id " +
                $"join delivery d on d.id = pharmacy_warehouse.id_delivery " +
                $"join measure_unit mu on mu.id = m.id_measure_unit " +
                $"join producer p on p.id = m.id_producer where pharmacy_warehouse.id={medicineId};";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetMedicine()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"SELECT * FROM medicine;";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetMeasureUnit()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"SELECT * FROM measure_unit;";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetProducer()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"SELECT * FROM producer;";
            return command.ExecuteReader();
        }
        public static SQLiteDataReader GetDelivery()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"SELECT * FROM delivery;";
            return command.ExecuteReader();
        }

        public static SQLiteDataReader GetPharmacyWarehouse()
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"SELECT pharmacy_warehouse.id,name FROM pharmacy_warehouse " +
                                  $"join medicine m on m.id = pharmacy_warehouse.id_medicine;";
            return command.ExecuteReader();
        }
        public static void InsertMedicine(Medicine medicine)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"INSERT into medicine(id_measure_unit, id_producer, name, image, description) " +
                                  $"VALUES  (:id_measure_unit,:id_producer, :name, :image, :description);";
            command.Parameters.AddWithValue("id_measure_unit", medicine.IdMeasureUnit);
            command.Parameters.AddWithValue("id_producer", medicine.IdProducer);
            command.Parameters.AddWithValue("name", medicine.Name);
            command.Parameters.AddWithValue("image", medicine.Image);
            command.Parameters.AddWithValue("description", medicine.Description);
            command.ExecuteNonQuery();   
        }

        public static void InsertPharmacyWarehouse(PharmacyWarehouse pharmacyWarehouse)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText =
                $"insert into pharmacy_warehouse(id_medicine, id_delivery, quantity, current_quantity_in_stock, availability, price) VALUES " +
                $"(:id_medicine, :id_delivery, :quantity, :current_quantity_in_stock, :availability, :price);";
            command.Parameters.AddWithValue("id_medicine", pharmacyWarehouse.IdMedicine);
            command.Parameters.AddWithValue("id_delivery", pharmacyWarehouse.IdDelivery);
            command.Parameters.AddWithValue("quantity", pharmacyWarehouse.Quantity);
            command.Parameters.AddWithValue("current_quantity_in_stock", pharmacyWarehouse.CurrentQuantityInStock);
            command.Parameters.AddWithValue("availability", pharmacyWarehouse.Availability);
            command.Parameters.AddWithValue("price", pharmacyWarehouse.Price);
            command.ExecuteNonQuery();
        }
        public static void InsertDelivery(Delivery delivery)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText =
                $"insert into delivery(date_receipt, supplier) VALUES " +
                $"(:date_receipt, :supplier);";
            command.Parameters.AddWithValue("date_receipt", delivery.DateReceipt);
            command.Parameters.AddWithValue("supplier", delivery.Supplier);
            command.ExecuteNonQuery();
        }

        public static void DeletePharmacyWarehouse(int idPharmacyWarehouse)
        {
            using var command = _connection.CreateCommand();
            command.Connection = _connection;
            command.CommandText = $"DELETE FROM pharmacy_warehouse where id={idPharmacyWarehouse};";
            command.ExecuteNonQuery();
        }
    }
}