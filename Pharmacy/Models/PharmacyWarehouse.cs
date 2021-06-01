namespace Pharmacy.Models
{
    public class PharmacyWarehouse
    {
        public int Id { get; set; }
        public int IdMedicine { get; set; }
        public int IdDelivery { get; set; }
        public int Quantity { get; set; }
        public int CurrentQuantityInStock { get; set; }
        public int Availability { get; set; }
        public int Price { get; set; }

        public PharmacyWarehouse(int id, int idMedicine, int idDelivery, int quantity, int currentQuantityInStock, int availability, int price)
        {
            Id = id;
            IdMedicine = idMedicine;
            IdDelivery = idDelivery;
            Quantity = quantity;
            CurrentQuantityInStock = currentQuantityInStock;
            Availability = availability;
            Price = price;
        }
    }
}