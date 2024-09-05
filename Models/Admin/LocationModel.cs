using System.ComponentModel.DataAnnotations;

namespace admin_Landing.Models
{

	public class Location
	{
		[Required]
		public string ClientName { get; set; }

		[Required]
		public string FridgeType { get; set; }

		[Required]
		public string AddressLine1 { get; set; }

		public string AddressLine2 { get; set; }

		[Required]
		public string City { get; set; }

		[Required]
		public string Province { get; set; }
	}

}
