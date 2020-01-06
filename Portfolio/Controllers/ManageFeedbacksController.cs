using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ManageFeedbacksController : Controller
    {
        readonly ApplicationDbContext _context;
        public ManageFeedbacksController() => _context = new ApplicationDbContext();
        // GET: ManageFeedbacks
        public ActionResult Index()
        {
            var feedback = _context.Feedback.Where(f => f.Engedelyezett==false).ToList().OrderByDescending(s=>s.Id);
            return View(feedback);
            
        }
        public ActionResult Allow(int id)
        {
            var feedback=_context.Feedback.SingleOrDefault(u => u.Id == id);
            if (feedback == null) return HttpNotFound();
            feedback.Lattamozott = true;
            feedback.Engedelyezett = true;
            _context.SaveChanges();
            return RedirectToAction("Index", "ManageFeedbacks");
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