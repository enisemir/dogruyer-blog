using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace User_Out.Models
{
    public class User
    {

        [Required(ErrorMessage = "Please Enter Your Name")]
        public string UserName { get; set; }        
        [Required(ErrorMessage ="Please Enter Your Email")]
        [RegularExpression("@",ErrorMessage ="Please Enter a Valid Email Adres")]
        public string Email { get; set; }
        public int Password { get; set; }
   
    }
}