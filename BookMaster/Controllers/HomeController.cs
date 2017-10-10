﻿using BookMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookMaster.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext data;
        public ActionResult Index()
        {
            data = new ApplicationDbContext();

            return View(data.Books.ToList());
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