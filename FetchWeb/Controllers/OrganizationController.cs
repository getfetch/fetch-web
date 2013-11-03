using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Interfaces;
using Domain.Objects;

namespace FetchWeb.Controllers
{
    public class OrganizationController : Controller
    {
        //
        // GET: /Organization/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Organization/Details/5
        public ActionResult Details(int id)
        {
            IOrganization org = new Organization();
            org.Details(id);
            return View("Details", org);
        }

        //
        // GET: /Organization/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        //
        // POST: /Organization/Create
        [HttpPost]
        public ActionResult Create(Organization org)
        {
            try
            {
                org.Create();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Organization/Edit/5
        public ActionResult Edit(int id)
        {
            IOrganization org = new Organization();
            org.Details(id);
            return View("Edit", org);
        }

        //
        // POST: /Organization/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Organization org)
        {
            try
            {
                // TODO: Add update logic here
                org.Edit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Organization/Delete/5
        public ActionResult Delete(int id)
        {
            IOrganization org = new Organization();
            org.Details(id);
            return View("Delete", org);
        }

        //
        // POST: /Organization/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Organization org)
        {
            try
            {
                org.Delete();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
