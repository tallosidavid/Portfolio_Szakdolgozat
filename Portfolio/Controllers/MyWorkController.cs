using System;
using AutoMapper;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    [AllowAnonymous]
    public class MyWorkController : Controller
    {
        readonly ApplicationDbContext _context;

        public MyWorkController() => _context = new ApplicationDbContext();

        // GET: MyWork
        public ActionResult Index()
        {
            var munkaim = _context.Munkaim.ToList();
            return View(munkaim);
        }

       

        [Authorize(Roles ="Admin")]
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

                return View("Edit", vm);
            }


            if (munkaim.Id == 0)
            {
                _context.Munkaim.Add(munkaim);
            }
            else
            {
                var letezoMunka = _context.Munkaim.Single(u => u.Id == munkaim.Id);
                letezoMunka.Cim = munkaim.Cim;
                letezoMunka.Csillagozott = munkaim.Csillagozott;
                letezoMunka.HozzaadasDatuma = munkaim.HozzaadasDatuma;
                letezoMunka.Leiras = munkaim.Leiras;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "MyWork");
        }

        [Authorize(Roles = "Admin")]
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
    }
}
