using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class NotificationController : Controller
    {
        readonly ApplicationDbContext _context;
        public NotificationController() => _context = new ApplicationDbContext();
        // GET: Notification
        public ActionResult Email()
        {
            var lattamazott = _context.Email.Where((u => u.Lattamozott == false)).Count();
         
            return Content(lattamazott.ToString());
        }
        public ActionResult Feedback()
        {
            var lattamazott = _context.Feedback.Where((u => u.Lattamozott == false)).Count();

            return Content(lattamazott.ToString());
        }
    }
}