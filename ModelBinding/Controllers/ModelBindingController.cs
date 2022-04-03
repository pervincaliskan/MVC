using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBinding.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: ModelBinding
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kayit()

        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(string urunad)

        {
            return View();
        }
    }
}