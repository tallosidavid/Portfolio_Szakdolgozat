using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        readonly ApplicationDbContext _context;
        public ExperienceController() => _context = new ApplicationDbContext();
        // GET: Experience
        public ActionResult Index()
        {
            var xp = _context.Experience.ToList().OrderByDescending(s => s.Id);
            return View(xp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Experience experience)
        {
             
            if (experience.Id == 0 || experience.Id == null)
            {
                if (experience.Meddig == DateTime.MinValue)
                {
                    experience.Meddig = DateTime.Now;
                } 
                _context.Experience.Add(experience);
            }
            else
            {
                var letezoXP = _context.Experience.Single(u => u.Id == experience.Id);
                letezoXP.Aktiv = experience.Aktiv;
                letezoXP.Hol = experience.Hol;
                letezoXP.Mit = experience.Mit;
                letezoXP.Mettol = experience.Mettol;
                letezoXP.Meddig = experience.Meddig; 
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
         
        public ActionResult Delete(int id)
        {
            var xp = _context.Experience.Find(id);
            if (xp == null) return HttpNotFound();
            _context.Experience.Remove(xp);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult New()
        {
            return View("New");
        }
        public ActionResult Edit(int id)
        {
            var experience = _context.Experience.SingleOrDefault(u => u.Id == id);
            if (experience == null) return HttpNotFound();
            var vm = new ExperienceViewModel()
            {
                Experience =experience
            };
            return View("New", vm);
        }
    }
}
