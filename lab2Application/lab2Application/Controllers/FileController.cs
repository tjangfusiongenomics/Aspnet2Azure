using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2Application.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));

            for(int i=0; i<files.Length; i++)
            {
                int last_slash = files[i].Split('\\').Length - 1;
                files[i] = files[i].Split('\\')[last_slash].Split('.')[0];
            }
            ViewBag.files = files;
            return View();
        }
        public ActionResult Display(string id)
        {
            string tmp = id;
            string path = Server.MapPath("~/TextFiles/" + id + ".txt");
            StreamReader reader = new StreamReader(path);
            string line = reader.ReadToEnd();

            ViewBag.content = line;

            return View();
        }
    }
}