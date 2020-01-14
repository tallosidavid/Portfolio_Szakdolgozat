using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models
{
    public class SumViewModel
    {
        public virtual IEnumerable<Feedback> Feedbacks { get; set; }
        public virtual IEnumerable<Munkaim> Munkaims { get; set; }
    }
}