using System.ComponentModel.DataAnnotations;
using WebApplication11.Models.Customer;

namespace WebApplication11.Models.CustomerCare
{
    public class Fridge
    {
        [Key]
        public int FridgeId { get; set; }
        [Required]
        public string FridgeType { get; set; }

        public ICollection<FridgeAllocation> FridgeAllocations { get; set; }
        public ICollection<PurchaseRequest> PurchaseRequests { get; set; }
        public ICollection<C_CreateFault> C_CreateFaults { get; set; }
    }
}
