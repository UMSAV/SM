using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ism")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Familya")]
        [MaxLength(50)]
        public string LastName  { get; set; }

        [Required]
        [Display(Name = "Sharif")]
        [MaxLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Passport raqam")]
        [MaxLength(50)]
        public string PassportNumber { get; set; }

        [Required]
        [Display(Name = "Login")]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [Display(Name = "Parol")] 
        [MaxLength(50)]
        public string Parol { get; set; }

        public string Department { get; set; }
    }
}
