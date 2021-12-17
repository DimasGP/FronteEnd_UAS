using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd_TAS.Models
{
    public class Student
    {
        public string studentID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100,MinimumLength =2)]
        public string firstName { get; set; }

         [Required]
        public string lastName { get; set; }
        public DateTime enrollmentDate { get; set; }
        
        
    }
}