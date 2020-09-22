using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicallyLoadingContentWithJquery_Ajax_ASPNETMVC.Models;

namespace DynamicallyLoadingContentWithJquery_Ajax_ASPNETMVC.Controllers
{
    public class HomeController : Controller
    {

        employeeDBEntities db = new employeeDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.EmployeeInfoes.ToList());
        }

        public ActionResult EmpInfo(int id)
        {
            List<EmployeeInfo> empinfo = db.EmployeeInfoes.Where(n => n.EmpId == id).ToList();
            return View(empinfo);
        }
        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
