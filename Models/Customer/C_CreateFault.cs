using System.ComponentModel.DataAnnotations;
using WebApplication11.Models.CustomerCare;

namespace WebApplication11.Models.Customer
{
    public class C_CreateFault
    {
        [Key]
        public int C_FaultId { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public String FaultDescription { get; set; }

        public int FridgeId { get; set; }
        public Fridge Fridges { get; set; }
    }
}
