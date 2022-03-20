using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angellis_Pasteleria.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Catalog()
        {
            return View();
        }
        public ActionResult Cake()
        {
            return View();
        }
        public ActionResult Dessert()
        {
            return View();
        }
    }
}