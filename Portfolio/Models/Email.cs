using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Email
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "You must fill this field!")]
        [Display(Name = "Your Name:")]
        public string Felado { get; set; }
        [Required(ErrorMessage = "You must fill this field!")]
        [Display(Name = "Your e-mail address:")]
        public string EmailCim { get; set; }
        [Required(ErrorMessage = "You must fill this field!")]
        [Display(Name = "Message:")]
        public string Uzenet { get; set; }
        public DateTime Idopont { get; set; }
        public bool Lattamozott { get; set; }
    }
}