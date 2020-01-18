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
    [Authorize(Roles = "Admin")]
    public class MyWorkController : Controller
    {
        readonly ApplicationDbContext _context;
        public MyWorkController() => _context = new ApplicationDbContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            var munkaim = _context.Munkaim.ToList().OrderByDescending(s => s.HozzaadasDatuma).OrderByDescending(s => s.Csillagozott);
            return View(munkaim);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Munkaim munkaim)
        {
            if (!ModelState.IsValid)
            {
                var vm = new WorkViewModel
                {
                    Munkaim = munkaim
                };
                TempData["error"] = "Something went wrong! Please try again later!";
                return View("Edit", vm);
            }

            if (munkaim.Id == null || munkaim.Id == 0)
            {
                _context.Munkaim.Add(munkaim);
            }
            else
            {
                var letezoMunka = _context.Munkaim.Single(u => u.Id == munkaim.Id);
                letezoMunka.Cim = munkaim.Cim;
                letezoMunka.Csillagozott = munkaim.Csillagozott;
                letezoMunka.HozzaadasDatuma = munkaim.HozzaadasDatuma;
                letezoMunka.SlideShow = munkaim.SlideShow;
                letezoMunka.Leiras = munkaim.Leiras;
            }
            TempData["success"] = "You successfully uploaded a new project!";
            _context.SaveChanges();
            return RedirectToAction("Index", "MyWork");
        }
        public ActionResult Edit(int id)
        {
            var munka = _context.Munkaim.SingleOrDefault(u => u.Id == id);
            if (munka == null) return HttpNotFound();
            var vm = new WorkViewModel()
            {
                Munkaim = munka
            };
            return View("Edit", vm);
        }
        public ActionResult Delete(int id)
        {
            var munka = _context.Munkaim.Find(id);
            if (munka == null) return HttpNotFound();
            _context.Munkaim.Remove(munka);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult New()
        {
            return View("New");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewSave(HttpPostedFileBase postedFile, Munkaim munkaim)
        {
            if (postedFile.ContentLength > 0)
            {
                string _FileName = Path.GetFileName(postedFile.FileName);
                string _path = Path.Combine(Server.MapPath("~/Content/Works"), _FileName);
                postedFile.SaveAs(_path);
                munkaim.eleresiUt = _FileName;
                if (!ModelState.IsValid)
                {
                    var vm = new WorkViewModel
                    {
                        Munkaim = munkaim
                    };
                    return View("New", vm);
                }
                if (munkaim.HozzaadasDatuma == null)
                {
                    munkaim.HozzaadasDatuma = DateTime.Now;
                }
                _context.Munkaim.Add(munkaim);
                _context.SaveChanges();
                TempData["success"] = "You successfully uploaded a new project!";
                return RedirectToAction("Index", "MyWork");
            }
            return View("Index");



        }
        [AllowAnonymous]
        public ActionResult Videos()
        {
            var munkaim = _context.Munkaim.Where(s => s.eleresiUt.Contains("mp4")).ToList().OrderByDescending(s => s.HozzaadasDatuma).OrderByDescending(s => s.Csillagozott);
            return View("index", munkaim);
        }
        [AllowAnonymous]
        public ActionResult Images()
        {
            var munkaim = _context.Munkaim.Where(s => s.eleresiUt.Contains("png") || s.eleresiUt.Contains("jpg")).ToList().OrderByDescending(s => s.HozzaadasDatuma).OrderByDescending(s => s.Csillagozott);
            return View("index", munkaim);
        }
    }
}

