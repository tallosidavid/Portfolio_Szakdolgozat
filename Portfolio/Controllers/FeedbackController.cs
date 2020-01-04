using System;
using AutoMapper;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    [AllowAnonymous]
    public class FeedbackController : Controller
    {
        readonly ApplicationDbContext _context;
        public FeedbackController() => _context = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                var vm = new FeedbackViewModel {
                    Feedback = feedback
                };
                return View("New", vm);
            }

            if (feedback.Id == null || feedback.Id == 0)
            {
                _context.Feedback.Add(feedback);
            }

            return View("New");
        }
    }
}