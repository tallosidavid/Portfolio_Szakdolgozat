using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        // GET: Elerhetoseg
        public ActionResult Index()
        {
            return View();
        }
    }
}