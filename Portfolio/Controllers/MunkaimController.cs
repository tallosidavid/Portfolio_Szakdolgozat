using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class MunkaimController : Controller
    {
        // GET: Munkaim
        public ActionResult Index()
        {
            return View();
        }

        // GET: Munkaim/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Munkaim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Munkaim/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Munkaim/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Munkaim/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Munkaim/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Munkaim/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
