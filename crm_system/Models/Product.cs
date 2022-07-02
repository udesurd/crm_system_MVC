using System.ComponentModel.DataAnnotations;

namespace crm_system.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public List<Sell> Sells { get; set; } = new List<Sell>();


    }
}
