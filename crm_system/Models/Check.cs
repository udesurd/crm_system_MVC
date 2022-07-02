using System.ComponentModel.DataAnnotations;

namespace crm_system.Models
{
    public class Check
    {
        [Key]
        public int CheckId { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateTime { get; set; }

        public List<Sell> Sells { get; set; } = new List<Sell>();
    }
}
