using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models.CustomerCare
{
    public class PurchaseRequest
    {
        [Key]
        public int PurchaseId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public int FridgeId { get; set; }
        public Fridge Fridges { get; set; }

        //Add Supplier as foreignkey
    }
}
