using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models.CustomerCare
{
    public class Decision
    {
        [Key]
        public int DecisionId { get; set; }

        [Required]
        public string DecisionName { get; set; }

        public ICollection<FridgeAllocation> FridgeAllocations { get; set; }
    }
}
