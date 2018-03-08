using Memberships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<ThumbnailAreaModel>();
            model.Add(new ThumbnailAreaModel
            {
                Title="Area title",
                Thumbnails = new List<ThumbnailModel>()
            });
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}