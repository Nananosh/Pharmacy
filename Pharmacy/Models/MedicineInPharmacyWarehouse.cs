namespace Pharmacy.Models
{
    public class MedicineInPharmacyWarehouse
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int CurrentQuantityInStock { get; set; }
        public int Availability { get; set; }
        public int Price { get; set; }
        public string MedicineName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string DateReceipt { get; set; }
        public string Supplier { get; set; }
        public string MeasureUnitName { get; set; }
        public string ProducerName { get; set; }

        public MedicineInPharmacyWarehouse(int id, int quantity, int currentQuantityInStock, int availability, int price, string medicineName, string image, string description, string dateReceipt, string supplier, string measureUnitName, string producerName)
        {
            Id = id;
            Quantity = quantity;
            CurrentQuantityInStock = currentQuantityInStock;
            Availability = availability;
            Price = price;
            MedicineName = medicineName;
            Image = image;
            Description = description;
            DateReceipt = dateReceipt;
            Supplier = supplier;
            MeasureUnitName = measureUnitName;
            ProducerName = producerName;
        }
    }
    
}