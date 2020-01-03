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
    [Authorize(Roles = "Admin")]
    public class MyWorkController : Controller
    {
        readonly ApplicationDbContext _context;

        public MyWorkController() => _context = new ApplicationDbContext();

        // GET: MyWork
        [AllowAnonymous]
        public ActionResult Index()
        {
            var munkaim = _context.Munkaim.ToList();
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
                letezoMunka.Leiras = munkaim.Leiras;
            }
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
            
            return View("Edit");
        }
    }
}
