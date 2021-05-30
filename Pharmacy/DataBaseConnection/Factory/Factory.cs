using System.Collections.Generic;
using System.Data.SQLite;
using Pharmacy.Models;

namespace Pharmacy.DataBaseConnection.Factory
{
    public static class Factory
    {
        public static List<MedicineInPharmacyWarehouse> GetMedicineInPharmacyWarehouse(SQLiteDataReader dataReader)
        {
            List<MedicineInPharmacyWarehouse> list = new List<MedicineInPharmacyWarehouse>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var quantity = dataReader.GetInt32(1);
                var currentQuantityInStock = dataReader.GetInt32(2);
                var availability = dataReader.GetInt32(3);
                var price = dataReader.GetInt32(4);
                var medicineName = dataReader.GetString(5);
                var image = dataReader.GetString(6);
                var description = dataReader.GetString(7);
                var dateReceipt = dataReader.GetString(8);
                var supplier = dataReader.GetString(9);
                var measureUnitName = dataReader.GetString(10);
                var producerName = dataReader.GetString(11);
                list.Add(new MedicineInPharmacyWarehouse(id,quantity,currentQuantityInStock,availability,price,
                    medicineName,image,description,dateReceipt,supplier,measureUnitName,producerName));
            }
            return list;
        }
        public static List<MeasureUnit> GetMeasureUnit(SQLiteDataReader dataReader)
        {
            List<MeasureUnit> list = new List<MeasureUnit>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var name = dataReader.GetString(1);
                list.Add(new MeasureUnit(id,name));
            }
            return list;
        }
        public static List<Producer> GetProducer(SQLiteDataReader dataReader)
        {
            List<Producer> list = new List<Producer>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var name = dataReader.GetString(1);
                list.Add(new Producer(id,name));
            }
            return list;
        }
        public static List<Delivery> GetDelivery(SQLiteDataReader dataReader)
        {
            List<Delivery> list = new List<Delivery>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var dateReceipt = dataReader.GetString(1);
                var supplier = dataReader.GetString(2);
                list.Add(new Delivery(id,dateReceipt,supplier));
            }
            return list;
        }
        public static List<Medicine> GetMedicine(SQLiteDataReader dataReader)
        {
            List<Medicine> list = new List<Medicine>();
            while (dataReader.Read())
            {
                var id = dataReader.GetInt32(0);
                var idMeasureUnit = dataReader.GetInt32(1);
                var idProducer = dataReader.GetInt32(2);
                var name = dataReader.GetString(3);
                var image = dataReader.GetString(4);
                var description = dataReader.GetString(5);
                list.Add(new Medicine(id,idMeasureUnit,idProducer,name,image,description));
            }
            return list;
        }
    }
}