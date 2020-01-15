using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class SumViewModel
    {
        public List<Feedback> Feedbacks { get; set; }
        public List<Munkaim> Munkaims { get; set; }
        public List<Experience> Experiences { get; set; }
    }
}