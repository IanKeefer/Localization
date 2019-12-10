using LocalizationPOC.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalizationPOC.Controllers
{
    public class ResourcesController : BaseController
    {

        public ActionResult Index()
        {
            return PartialView();
        }

    }
}