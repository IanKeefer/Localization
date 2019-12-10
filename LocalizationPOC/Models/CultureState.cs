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
    public class CultureState
    {
        protected HttpSessionState session;

        public static Culture Culture
        {
            get
            {
                var current = Thread.CurrentThread.CurrentUICulture.Name;
                return current.GetCultureFromShortName();
            }
            set => Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(value.GetShortName());

        }

        public CultureState(HttpSessionState session)
        {
            this.session = session;
        }
    }

    public enum Culture
    {
        [Display(Name = "English", ShortName = "en-US")]
        ENGLISH,

        [Display(Name = "German", ShortName = "de-DE")]
        GERMAN
    }
}