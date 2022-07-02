using System.ComponentModel.DataAnnotations;

namespace crm_system.Models
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Check> Checks { get; set; } = new List<Check>();
    }
}
