using System;
using System.ComponentModel.DataAnnotations;

namespace Bakery.WebAPI.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        [Range(0.01, 9999.99)]
        public decimal InvoicePrice {get; set; }
    }
}