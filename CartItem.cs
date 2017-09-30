using BookMaster.Models;
using System.ComponentModel.DataAnnotations;

namespace BookMaster.Models
{
	//schema that defines each book a user adds to the shopping cart.
	public class CartItem
	{
		[Key]
		public int CartItemId { get; set; }

		public int CartId { get; set; }

		public int TotalItems { get; set; }

		[Required]
		public string ProductId { get; set; }

		public double money { get; set; }
	}
}
