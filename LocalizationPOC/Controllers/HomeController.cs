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
            return View(new Models.Localization());
        }

        public ActionResult SetCulture(string set)
        {
            ChangeCulture(set);
            return Redirect(Request.UrlReferrer.ToString());
        }

        private void ChangeCulture(string lang)
        {
            Response.Cookies.Remove("Language");
            HttpCookie languageCookie = System.Web.HttpContext.Current.Request.Cookies["Language"];
            if (languageCookie == null)
            {
                languageCookie = new HttpCookie("Language");
            }
            languageCookie.Value = lang;
            languageCookie.Expires = DateTime.Now.AddDays(30); // arbirary, no expiration?
            Response.SetCookie(languageCookie);
        }
    }
}