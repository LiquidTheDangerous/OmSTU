﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blogDBApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult SearchSelect()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Zaitsev Vladimir Alexandrovich";

            return View();
        }
    }
}