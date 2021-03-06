﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_Task.Models;

namespace Test_Task.Controllers
{
    public class HomeController : Controller
    {
        TicketContext tc = new TicketContext();

        public ActionResult Index()
        {
            return View(tc.Tickets);
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