using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        readonly ApplicationDbContext _context;
        public HomeController() => _context = new ApplicationDbContext();
        // GET: Home
        public ActionResult Index()
        {


            var feedback = _context.Feedback.ToList();
            var work = _context.Munkaim.ToList();




            SumViewModel model = new SumViewModel();
            model.Feedbacks = feedback;
            model.Munkaims = work;
            return View(model);
        }
    }
}