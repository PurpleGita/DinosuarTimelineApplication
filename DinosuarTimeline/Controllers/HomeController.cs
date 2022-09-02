using DinosuarTimeline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinosuarTimeline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult DinoDex()
        {
            ViewBag.Message = "DinoDex page.";

            List<DinosaursModel> dinosaurs = new List<DinosaursModel>();

            dinosaurs.Add(new DinosaursModel {name = "Tyrannosaurus" , race = "BigDino", firsApperaed = 40, lastApperaed = 900, description = "a very big dino and a good dog", imagePath = "/T-Rex.jpg"});
            dinosaurs.Add(new DinosaursModel { name = "JackTheHonker", race = "Goose", firsApperaed = 10, lastApperaed = 50, description = "not a good dog" , imagePath = "/Goose.png" });

            return View(dinosaurs);
        }
    }
}