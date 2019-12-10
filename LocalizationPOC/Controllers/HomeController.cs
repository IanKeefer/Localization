using LocalizationPOC.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalizationPOC.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
            var model = new Models.Localization();
            return View(model);
        }

        public ActionResult SetCulture(int id)
        {
            Culture culture = Culture.GERMAN;
            CultureState.Culture = culture;
            return Redirect(Request.UrlReferrer.ToString());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}