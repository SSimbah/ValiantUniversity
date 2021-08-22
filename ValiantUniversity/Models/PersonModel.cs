using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValiantUniversity.Models
{
    public class PersonModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter first name"), MaxLength(50)]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter last names"), MaxLength(50)]
        public string LastName { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Please enter gender")]
        public string Gender { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Please enter age")]
        public int Age { get; set; }


        [DisplayName("Full Name")]
        public string FullName 
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
