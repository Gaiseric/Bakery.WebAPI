using System.ComponentModel.DataAnnotations;

namespace Bakery.WebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [EmailAddress, Required]
        public string OrderEmail { get; set; }

        [Required]
        public string OrderShipping { get; set; }

        [Required]
        public string OrderProduct { get; set; } 

        public int OrderQuantity { get; set; } = 1;
    }
}