using System.ComponentModel.DataAnnotations;

namespace CashDash.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int CategoryID { get; set;}
        public Category Category { get; set; }
        [Required]
        public int PriceInCents { get; set; }
        public int InventoryCount { get; set; } 

    }
}
