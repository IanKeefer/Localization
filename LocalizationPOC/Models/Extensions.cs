using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace LocalizationPOC.Localization
{
    public static class Extensions
    {
        public static string GetName(this Culture culture)
        {
            return culture.GetDisplayAttributes().Name;
        }

        public static string GetShortName(this Culture culture)
        {
            return culture.GetDisplayAttributes().ShortName;
        }

        private static DisplayAttribute GetDisplayAttributes(this Culture culture)
        {
            return culture.GetType().GetMember(culture.ToString())[0].GetCustomAttribute<DisplayAttribute>();
        }

        public static Culture GetCultureFromShortName(this string current)
        {
            foreach (Culture culture in Enum.GetValues(typeof(Culture)))
            {
                string cultureName = culture.GetShortName();
                if (cultureName == current)
                {
                    return culture;
                }
            }
            return Culture.ENGLISH;
        }

    }
}