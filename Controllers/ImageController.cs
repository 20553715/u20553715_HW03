using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using u20553715_HW03.Models;

namespace u20553715_HW03.Controllers
{
    public class ImageController : Controller
    {

        // GET: File
        public ActionResult Index()
        {
            string[] fileDirectory = Directory.GetFiles(Server.MapPath("~/Media/Images/"));
            List<FileModel> files = new List<FileModel>();

            foreach (string filePath in fileDirectory)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(filePath) });
            }

            return View(files);

        }

        public FileResult DownloadFile(string fileName)
        {
            //Build
            string path = Server.MapPath("~/Media/Images/") + fileName;

            //Read
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send
            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult DeleteFile(string fileName)
        {
            string path = Server.MapPath("~/Media/Images/") + fileName;
            System.IO.File.Delete(path);

            return RedirectToAction("Index");
        }
    }
}
