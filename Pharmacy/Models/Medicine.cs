namespace Pharmacy.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public int IdMeasureUnit { get; set; }
        public int IdProducer { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public Medicine(int id, int idMeasureUnit, int idProducer, string name, string image, string description)
        {
            Id = id;
            IdMeasureUnit = idMeasureUnit;
            IdProducer = idProducer;
            Name = name;
            Image = image;
            Description = description;
        }

        public Medicine()
        {
            
        }
    }
}