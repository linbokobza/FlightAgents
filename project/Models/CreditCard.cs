using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace project.Models
{
    public class CreditCard
    {
        
        [Key]
        [StringLength(9, ErrorMessage = "9 digits required")]
        public string ID { get; set; }
        [Required(ErrorMessage = "Required Full name")]
        [Display(Name = "Full name")]
        [MinLength(2, ErrorMessage = "Minimun 2 char required"), MaxLength(40, ErrorMessage = "Maximun 40 char allowed")]
        public string FullName { get; set; }

        [StringLength (16, ErrorMessage = "16 digits required")]
        public string CardNumber { get; set; }

        public string CardExp { get; set; }

        [StringLength(3, ErrorMessage = "3 digits required")]
        public string CVV { get; set; }
    }
}