using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace u20553715_HW03.Models
{
    public class FileModel
    {
        

        public string FileName { get; set; }

        public HttpPostedFileBase Files { get; set; }

        public string File { get; set; }
    }
}