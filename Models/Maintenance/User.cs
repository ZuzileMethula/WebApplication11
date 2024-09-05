﻿using System.ComponentModel.DataAnnotations;
namespace FM.WebSite.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required,StringLength(10)]
        public string Gender {  get; set; }
        [Required, DataType(DataType.Date), Display(Name ="Date Of Birth")]      
        public DateTime DOB { get; set; }
        [Required]
        [StringLength(75)]
        public string Email { get; set; }
        [Required]
        [StringLength (40)]
        public string Password { get; set; }
        [Required, Display(Name ="Phone Number")]
        [StringLength(12)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required, Display(Name="Zip Code")]
        [StringLength(10)]
        public string ZipCode { get; set; }
        [StringLength(10)]
        public string UserType { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public Employee Employees { get; set; }
        

    }
}
