using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FetchWeb.Models;

namespace FetchWeb.Controllers
{
    public class DogsController : Controller
    {
        //
        // GET: /Dogs/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Dogs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Dogs/Create
        public ActionResult Create()
        {
            return View("Create", new DogCreateModel());
        }

        //
        // POST: /Dogs/Create
        [HttpPost]
        public ActionResult Create(DogCreateModel dog)
        {
            try
            {
                dog.Create();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Dogs/Edit/5
        public ActionResult Edit(int id)
        {
            DogEditModel model = new DogEditModel();
            model.Load(id);
            return View("Edit", model);
        }

        //
        // POST: /Dogs/Edit/5
        [HttpPost]
        public ActionResult Edit(DogEditModel model)
        {
            try
            {
                model.Update();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Dogs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Dogs/Delete/5
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
