using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestControllers.Models
{
    [Table("claims")]
    public class Claims
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime Date { get; set; }

        public int Vehicle_Id { get; set; }


    }
}
