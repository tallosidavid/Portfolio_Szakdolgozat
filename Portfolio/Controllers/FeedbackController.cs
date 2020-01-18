using System;
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
            var feedback = _context.Feedback.ToList().OrderByDescending(s=>s.Id);
            return View(feedback);
        }
        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Save(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                var vm = new FeedbackViewModel {
                    Feedback = feedback
                };
                TempData["error"] = "Something went wrong! Please try again later!";
                return View("New", vm);
            }

            if (feedback.Id == null || feedback.Id == 0)
            {
                if (feedback.Nev == null) feedback.Nev = "Anonymus";
                feedback.HozzaadasDatuma = DateTime.Now;
                feedback.Engedelyezett = false;
                feedback.Lattamozott = false;
               _context.Feedback.Add(feedback);
                
            }
            TempData["success"]="Thank you for your time! You successfully sended your question!";
            _context.SaveChanges();
            return RedirectToAction("../Feedback/Index");
        }

        public ActionResult Delete(int id)
        {
            var feedback = _context.Feedback.Find(id);
            if (feedback == null) return HttpNotFound();
            _context.Feedback.Remove(feedback);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}