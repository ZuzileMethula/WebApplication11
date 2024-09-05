using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models.CustomerCare
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string BusinessType { get; set; }

        public int ProfileRequestId { get; set; }
        public ProfileRequest ProfileRequests { get; set; }


        public ICollection<FridgeAllocation> FridgeAllocations { get; set; }
    }
}
