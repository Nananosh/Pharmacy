using System.Security.AccessControl;

namespace Pharmacy.Models
{
    public class MeasureUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MeasureUnit(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public MeasureUnit()
        {
        }
    }
}