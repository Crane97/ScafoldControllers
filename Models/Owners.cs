using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestControllers.Models
{
    [Table("Owners")]
    public class Owners
    {
        [Key]
        public int Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String DriverLicense { get; set; }

    }
}
