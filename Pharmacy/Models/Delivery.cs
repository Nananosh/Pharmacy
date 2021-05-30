namespace Pharmacy.Models
{
    public class Delivery
    {
        public int Id{ get; set; }
        public string DateReceipt { get; set; }
        public string Supplier { get; set; }

        public Delivery(int id, string dateReceipt, string supplier)
        {
            Id = id;
            DateReceipt = dateReceipt;
            Supplier = supplier;
        }

        public Delivery()
        {
            
        }
    }
}