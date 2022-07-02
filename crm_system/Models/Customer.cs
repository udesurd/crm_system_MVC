using System.ComponentModel.DataAnnotations;

namespace crm_system.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public List<Check> Checks { get; set; } = new List<Check>();
    }
}
