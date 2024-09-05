using System.ComponentModel.DataAnnotations;

namespace admin_Landing.Models
{
	public class EmployeeModel
	{
		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string IdentificationNo { get; set; }

		[Required]
		[EmailAddress]
		public string EmailAddress { get; set; }

		[Required]
		[Phone]
		public string PhoneNumber { get; set; }

		[Required]
		public string Address { get; set; }

		[Required]
		public string City { get; set; }

		[Required]
		public string Province { get; set; }

		[Required]
		public string Role { get; set; }

	}
}
