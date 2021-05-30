namespace Pharmacy.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Producer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}