using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class SeenEmailController : Controller
    {
        readonly ApplicationDbContext _context;
        public SeenEmailController() => _context = new ApplicationDbContext();
        // GET: SeenEmail
        public ActionResult Index()
        {
            var email = _context.Email.Where(f => f.Lattamozott == true).ToList().OrderByDescending(s => s.Id);
            return View(email);
        }
        public ActionResult Delete(int id)
        {
            var email = _context.Email.Find(id);
            if (email == null) return HttpNotFound();
            _context.Email.Remove(email);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}