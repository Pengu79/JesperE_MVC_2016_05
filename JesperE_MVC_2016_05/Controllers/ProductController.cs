using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JesperE_MVC_2016_05.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Details()
        {
            return PartialView();
        }

        public PartialViewResult Create()
        {
            return PartialView();
        }

    }
}