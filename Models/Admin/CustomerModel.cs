using System.ComponentModel.DataAnnotations;
namespace admin_Landing.Models

{

	public class Customer
	{
		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		[StringLength(20, MinimumLength = 10)]
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
		public DateTime Date { get; set; }

		[Required]
		public string FridgeType { get; set; }
	}



}
