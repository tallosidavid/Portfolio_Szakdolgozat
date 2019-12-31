using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class Munkaim
    {
        public int Id { get; set; }
        public bool Csillagozott { get; set; }
        public string Cim { get; set; } 
        public string Leiras { get; set; }
        public DateTime HozzaadasDatuma { get; set; }

    }
}