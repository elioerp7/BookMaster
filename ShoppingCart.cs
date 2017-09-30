using System.ComponentModel.DataAnnotations;

namespace BookMaster.Models
{
	public class ShoppingCart
	{
		[Key]
		public int CartId { get; set; }

		public int UserId { get; set; }

		public System.DateTime DateCreated { get; set; }

		public bool CheckedOut { get; set; }

	}
}
