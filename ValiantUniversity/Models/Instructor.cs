using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValiantUniversity.Models
{
    public class Instructor : PersonModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int InstructorID { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string InstructorEmail { get; set; }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please create your password")]
        public string InstructorPassword { get; set; }

        //public virtual ICollection<Course> Courses { get; set; }
    }
}
