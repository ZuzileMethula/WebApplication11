using System.ComponentModel.DataAnnotations;

namespace admin_Landing.Models
{
	public class FridgeModel
	{
		[Required]
		public string FridgeType { get; set; }

		[Required]
		public string QuantityInStock { get; set; }

		[Required]
		public string Price { get; set; }

		[Required]
		public string Condition { get; set; }


	}
}
