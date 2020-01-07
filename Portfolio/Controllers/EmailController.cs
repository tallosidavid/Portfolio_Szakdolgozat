using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class EmailController : Controller
    {
        readonly ApplicationDbContext _context;
        public EmailController() => _context = new ApplicationDbContext();
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Save(Email email)
        {
            if (!ModelState.IsValid)
            {
                var vm = new EmailViewModel
                {
                    Email=email
                };
                return View("New", vm);
            }

            if (email.Id == null || email.Id == 0)
            {
                email.Idopont = DateTime.Now;
                email.Lattamozott = false;
                _context.Email.Add(email);

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
    }
}