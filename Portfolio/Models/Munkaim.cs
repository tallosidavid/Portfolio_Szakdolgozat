using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Munkaim
    {
        public int? Id { get; set; }
        [Display(Name = "Favorite")]
        public bool Csillagozott { get; set; }
        [Required(ErrorMessage ="You must give a name for your project")]
        [Display(Name = "Name")]
        public string Cim { get; set; }
        [Required(ErrorMessage = "You must give a description for your project")]
        [Display(Name = "Description")]
        public string Leiras { get; set; }
        [Display(Name = "Date")]
        [Required(ErrorMessage = "You must give a date for your project")]
        public DateTime HozzaadasDatuma { get; set; }
        [Display(Name = "Show on Index page")]
        public bool SlideShow { get; set; }
        public string eleresiUt { get; set; }
        

    }
}