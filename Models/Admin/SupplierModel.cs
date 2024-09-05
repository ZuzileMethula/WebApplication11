using System.ComponentModel.DataAnnotations;
namespace admin_Landing.Models
{
	
	public class Supplier
	{
		[Required]
		public string CompanyName { get; set; }

		[Required]
		public string ContactPerson { get; set; }

		[Required]
		public int AccountNumber { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[Phone]
		public string PhoneNumber { get; set; }

		[Required]
		public string PhysicalAddress { get; set; }
	}

}
