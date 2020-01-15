using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Experience
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must give where you worked")]
        [Display(Name = "Where")]
        public string Hol { get; set; }
        [Required(ErrorMessage = "You must give what you did")]
        [Display(Name = "What")]
        public string Mit { get; set; }
        [Display(Name = "Now you working here")]
        public bool Aktiv { get; set; }
        [Required(ErrorMessage = "You must give when you started")]
        [Display(Name = "From")]
        
        public DateTime Mettol { get; set; } 
        [Display(Name = "Till")]
        public DateTime Meddig { get; set; }
        
        
    }
}