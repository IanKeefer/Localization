using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace LocalizationPOC.Models
{
    public class Localization
    {
        [Display(ResourceType = typeof(LocalResource.Resource), Name = "Sentence")]
        public string Sentence { get; set; }
    }
}