using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Portfolio.Models
{
    public class Feedback
    {
        public int? Id { get; set; }
       
        [Display(Name ="Name")]
        public string Nev { get; set; }
        [Required(ErrorMessage = "Write your feedback about me!")]
        [Display(Name = "Feedback")]
        public string Velemeny { get; set; }
        public bool Engedelyezett { get; set; }
        public bool Lattamozott { get; set; } 
    }
}