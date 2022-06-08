using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace u20553715_HW03.Controllers
{
    public class HomeController : Controller
    {
        //GET: Index
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //POST: Index
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase files, string File) //INSIDE HOME
        {
           

            if (files != null && files.ContentLength > 0 && File == "Document")
            {

                var fileName = Path.GetFileName(files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Documents/"), fileName);

                files.SaveAs(path);

            }
            if (files != null && files.ContentLength > 0 && File == "Image")
            {

                var fileName = Path.GetFileName(files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Images"), fileName);

                files.SaveAs(path);

            }
            if (files != null && files.ContentLength > 0 && File == "Video")
            {

                var fileName = Path.GetFileName(files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Video"), fileName);

                files.SaveAs(path);

            }
            // redirect back to the index action to show the form once again

            return RedirectToAction("Index");
        }
        public ActionResult About()
        {

            return View();
        }

        

    }
}