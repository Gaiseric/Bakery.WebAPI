using System.ComponentModel.DataAnnotations;

namespace Bakery.WebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Phone, Required]
        public string CustomerPhone { get; set; }

        [Required]
        public string OrderShipping { get; set; }

        [Required]
        public string OrderProduct { get; set; } 

        [Required]
        [Range(1,100)]
        public int OrderQuantity { get; set; }

        [Required]
        [Range(0.01, 9999.99)]
        public decimal OrderPrice { get; set; }

        [Required]
        public string OrderStatus {get; set; }
    }
}