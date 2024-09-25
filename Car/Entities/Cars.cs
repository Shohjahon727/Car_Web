using System.ComponentModel.DataAnnotations;

namespace Car.Entities
{
    public class Cars
    {
        [Required]
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
