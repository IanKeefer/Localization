using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Web.SessionState;

namespace LocalizationPOC.Localization
{
    public enum Culture
    {
        [Display(Name = "English", ShortName = "en-US")]
        ENGLISH,

        [Display(Name = "German", ShortName = "de-DE")]
        GERMAN
    }
}