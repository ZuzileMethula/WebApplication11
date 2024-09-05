using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models.CustomerCare
{
    public class ProfileRequest
    {
        [Key]
        public int ProfileRequestId { get; set; }
        public string CustomerLastName { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string Password { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
