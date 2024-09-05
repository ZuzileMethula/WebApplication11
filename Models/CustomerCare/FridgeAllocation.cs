using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models.CustomerCare
{
    public class FridgeAllocation
    {
        public int FridgeAllocationId { get; set; }
        [Required]
        
        public DateTime AllocationDate { get; set; }

        public DateTime? MaintananceDate { get; set; }

        // Foreign Key
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }

        public int DecisionId { get; set; }
        public Decision Decisions { get; set; }

        public int FridgeId { get; set; }
        public Fridge Fridges { get; set; }
    }
}
