using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutheDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage ="Can not exceed 20 characters")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"/^([a-z0-9_\.-]+)@([\da-z\.-]+)\.([a-z\.]{2,6})$/",
            ErrorMessage ="Invalid email format")]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }

        public string AvatarPath { get; set; }
    }
}
