using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarLove.Models;

namespace CarLove.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult CityStat()
        {
            var rand = new Random();
            int Current;
            int Capacity = rand.Next(100);
            using( var db = new MapleContext())
            {
                Capacity = db.Lots.FirstOrDefault().Maxsize;
                Current = db.Lots.FirstOrDefault().CurrentCount;
            }

            ViewData["Capacity"] =  Capacity;
            ViewData["Current"] = Current;
            //Console.WriteLine(ViewData["Lot"]);
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
