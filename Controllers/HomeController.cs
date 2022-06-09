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
        public ActionResult Index(HttpPostedFileBase Files, string File) 
        {
           

            if (Files != null && Files.ContentLength > 0 && File == "Document")
            {

                var fileName = Path.GetFileName(Files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Documents"), fileName);

                Files.SaveAs(path);

            }
            else if (Files != null && Files.ContentLength > 0 && File == "Image")
            {

                var fileName = Path.GetFileName(Files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Images"), fileName);

                Files.SaveAs(path);

            }
            else if (Files != null && Files.ContentLength > 0 && File == "Video")
            {

                var fileName = Path.GetFileName(Files.FileName);
                var path = Path.Combine(Server.MapPath("~/Media/Video"), fileName);

                Files.SaveAs(path);

            }
            

            return RedirectToAction("Index");
        }
        public ActionResult About()
        {

            return View();
        }


       
    }
}