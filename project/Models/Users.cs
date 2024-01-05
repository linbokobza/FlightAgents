using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class Users
    {
    
        [Required(ErrorMessage = "Required First name")]
        [Display(Name = "First name")]
        [MinLength(2, ErrorMessage = "Minimun 2 char required"), MaxLength(20, ErrorMessage = "Maximun 20 char allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required Last name")]
        [Display(Name = "Last name")]
        [MinLength(2, ErrorMessage = "Minimun 2 char required"), MaxLength(20, ErrorMessage = "Maximun 20 char allowed")]
        public string LastName { get; set; }

        [Key]
        [Required(ErrorMessage = "Required Email")]
        [Display(Name = "Email")]
        [MinLength(6, ErrorMessage = "Minimun 2 char required"), MaxLength(35, ErrorMessage = "Maximun 35 char allowed")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Required Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Minimun 5 char required"), MaxLength(10, ErrorMessage = "Maximun 10 char allowed")]
        public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Password not matched")]
        //[Display(Name = "Confirm Password")]
        //[DataType(DataType.Password)]
        //[MinLength(5, ErrorMessage = "Minimun 5 char required"), MaxLength(10, ErrorMessage = "Maximun 10 char allowed")]
        //public string ConfirmPassword { get; set; }

        [Display(Name = "Is Admin?")]
        public string IsAdmin { get; set; }
        public Users() { IsAdmin = "F"; }
    }
}