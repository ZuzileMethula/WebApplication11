using System.ComponentModel.DataAnnotations;

namespace WebApplication11.Models.CustomerCare
{
    public class FridgeScrap
    {
        [Key]
        public int ScarpId { get; set; }

        [Required]
        public string ScarpName { get; set; }

        //Fault table as foreing key
    }
}
