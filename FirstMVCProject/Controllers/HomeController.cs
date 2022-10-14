using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return Redirect("https://www.bang-olufsen.com/en/us");
        }
/*
        public ActionResult FirstAction()
        {
            return View();
        }
*/
        public ActionResult GoToProduct()
        {
            return RedirectToAction("AddProduct", "Product");

        }
        public ActionResult GoToUpdateProduct()
        {
            return RedirectToAction("updateProduct", "Product", new { ID = 20 });
        }
    }
}