using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Madera.Controllers
{
    public class ModifyCustomerController : Controller
    {
        // GET: ModifyCustomer
        public ActionResult Index()
        {
            return View();
        }

        // GET: ModifyCustomer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ModifyCustomer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ModifyCustomer/Create
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

        // GET: ModifyCustomer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ModifyCustomer/Edit/5
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

        // GET: ModifyCustomer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ModifyCustomer/Delete/5
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
