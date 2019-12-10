using LocalizationPOC.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LocalizationPOC.Controllers
{
    public class BaseController : Controller
    {
        //protected override void ExecuteCore()
        //{
        //    var current = this.Session["CurrentCulture"]?.ToString();
        //    Culture culture = Culture.GERMAN;
        //    if (Session == null || Session["CurrentCulture"] == null || Session["CurrentCulture"] == "")
        //    {
        //        var test = System.Configuration.ConfigurationManager.AppSettings["Culture"];
        //        this.Session["CurrentCulture"] = culture.GetShortName();
        //        CultureState.Culture = culture;
        //    }
        //    base.ExecuteCore();
        //}

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {


            HttpCookie languageCookie = System.Web.HttpContext.Current.Request.Cookies["Language"];
            if (languageCookie != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(languageCookie.Value);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(languageCookie.Value);
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            }


            base.Initialize(requestContext);
        }
        protected override bool DisableAsyncSupport => true;

    }

}