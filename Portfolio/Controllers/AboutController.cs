using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        // GET: Rolam
        public ActionResult Index()
        {
            return View();
        }
    }
}