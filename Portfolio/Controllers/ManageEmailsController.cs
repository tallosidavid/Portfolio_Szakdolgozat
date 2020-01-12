using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ManageEmailsController : Controller
    {
        readonly ApplicationDbContext _context;
        public ManageEmailsController() => _context = new ApplicationDbContext();
        // GET: ManageEmails
        public ActionResult Index()
        {
            var email = _context.Email.Where(f => f.Lattamozott == false).ToList().OrderByDescending(s => s.Id);
            return View(email);
        }

        public ActionResult Seen(int id)
        {
            var email = _context.Email.SingleOrDefault(u => u.Id == id);
            if (email == null) return HttpNotFound();
            email.Lattamozott = true;
            _context.SaveChanges();
            return RedirectToAction("Index", "ManageEmails");
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