using LocalizationPOC.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalizationPOC.Controllers
{
    public class BaseController : Controller
    {
        protected override void ExecuteCore()
        {
            Culture culture = Culture.ENGLISH;
            if (Session == null || Session["CurrentCulture"] == null || Session["CurrentCulture"] == "")
            {

                this.Session["CurrentCulture"] = "en-US";
            }
            else
            {
                culture = this.Session["CurrentCulture"].ToString().GetCultureFromShortName();
            }
            CultureState.Culture = culture;
            base.ExecuteCore();
        }

        protected override bool DisableAsyncSupport => true;

    }

}