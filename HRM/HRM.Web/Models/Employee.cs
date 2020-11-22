using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRM.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Display(Name ="Official Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$",ErrorMessage ="Invalid Email format")]
        [Required]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string PhotoPat { get; set; }
    }
} 
