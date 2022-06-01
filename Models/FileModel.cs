using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations; //Add for look and feel
using System.Web;

namespace u20553715_HW03.Models
{
    public class FileModel
    {
        //Display options.

        [Display(Name = "File Name")]
        public string FileName { get; set; }

        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] Files { get; set; }
    }
}