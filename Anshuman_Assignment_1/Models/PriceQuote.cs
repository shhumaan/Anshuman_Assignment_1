using System;
using System.ComponentModel.DataAnnotations;

namespace Anshuman_Assignment_1.Models
{
	public class PriceQuote
    {
        [Required(ErrorMessage = "Please enter a sales total.")] 
        [Range(0.01, double.MaxValue, ErrorMessage = "Sales total must be greater than 0.")] 
        public decimal SalesTotal { get; set; } 

        [Required(ErrorMessage = "Please enter a discount rate.")]
        [Range(0, 100, ErrorMessage = "Discount rate must be between 0 and 100.")]
        public decimal DiscountRate { get; set; }

        public decimal DiscountValue => SalesTotal * DiscountRate / 100;


        public decimal FinalTotal => SalesTotal - DiscountValue;
    }
}

