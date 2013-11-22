using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FetchWeb.Models;

//TODO: Remove dependency
using FetchDomain.Interfaces;
using FetchDomain.Objects;

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
            try
            {
                //IOrganization org = DependencyResolver.Current.GetService<IOrganization>();
                //org.Details(id);
                return View("Details");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
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
        public ActionResult Create(OrganizationCreateModel org)
        {
            try
            {
                org.Create();
                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View();
            }
        }

        //
        // GET: /Organization/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                //IOrganization org = new Organization();

                //org.Details(id);
                return View("Edit");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Details");
            }
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
                return View("Edit", org);
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
