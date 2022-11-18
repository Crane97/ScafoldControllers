using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestControllers.Models
{
    [Table("Vehicles")]
    public class Vehicles
    {
        [Key]
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Vin { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public int Owner_Id { get; set; }
    }
}
