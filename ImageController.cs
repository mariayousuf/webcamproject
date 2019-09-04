using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using image_processing.Models;
using Microsoft.AspNetCore.Http;

namespace image_processing.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Capture()
        {

            return View();

        }
        [HttpPost]
        public JsonResult capture_image(string name)
        {
            PhotoCaptureEntities db = new PhotoCaptureEntities();
            Image imageStore = new Image()
            {
                CreateDate = DateTime.Now,
                ImageBase64String = name,
                ImageId = 0


             
        };
            db.Images.Add(imageStore);


            db.SaveChanges();


            return Json(true);
        }
           
    }
}



     