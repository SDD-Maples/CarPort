﻿using System;
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
    
        public IActionResult LocSearch(string Loc, int? UserID  )
        {   
            ViewData["Search"] = Loc;
            ViewData["UserId"] =  UserID ?? -1;

            using( var db = new MapleContext())
            {
                if( Loc == "!!") return View(db.Lots.ToList());
                return View(db.Lots.Where(l=>l.Location.Contains(Loc)).ToList());
            }
            return View("Index");
        }

        public IActionResult ViewLot(int ID)
        {
            Lot ret;
            using( var db = new MapleContext())
            {
                ret = db.Lots.FirstOrDefault(l=>l.ID==ID);
            }

            return View(ret);
        }

        public IActionResult AddFavorite(int LotID, int UserID)
        {
            if( UserID == -1) return RedirectToAction("ViewLot",new{ID=LotID});
            using( var db = new MapleContext())
            {
                var flot = db.Lots.FirstOrDefault(l=>l.ID==LotID);
                flot.Users.Add(new FavourLots{ UserID=UserID, LotID=LotID, Lot=flot });
                db.SaveChanges();
            }
            return RedirectToAction("ViewLot",new{ID=LotID});
        }

        public IActionResult LoginPage()
        {
            ViewData["Message"] = "-1";
            return View();
        }
        
        public IActionResult LoginResult(string Username, string Password)
        {
            using( var db = new MapleContext())
            {
                var use = db.Users.
                    FirstOrDefault(u=>
                    u.Username== Username && u.Password==Password);
                
                if( use == null)
                {
                    ViewData["Message"] = "Login Failed, please try again";
                    return View("LoginPage");
                }

                use = db.Users
                    .Include(e => e.Favorites)
                    .ThenInclude(e => e.Lot)
                    .Where( z=>z.ID == use.ID).FirstOrDefault();

                var retList = use.Favorites.Select(e => e.Lot).ToList();

                return View("LocSearch", retList);
            }

        }
    }
}
