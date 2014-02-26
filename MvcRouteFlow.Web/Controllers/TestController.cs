﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRouteFlow.Web.Controllers
{

    public class TestController : Controller
    {
        
        
        public ActionResult Index()
        {
            return RouteFlow.Begin("create-article");
        }

        [RouteFlow(Path = "create-article", Step = 1, Select = When.Auto)]
        public ActionResult Page1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Page1(string post)
        {
            return RouteFlow.Next();
        }

        [RouteFlow(Path = "create-article", Step = 2, Select = When.Auto)]
        public ActionResult Page2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Page2(string post)
        {
            return RouteFlow.Next();
        }

        [RouteFlow(Path = "create-article", Step = 3, Select = When.Auto)]
        public ActionResult Page3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Page3(string post)
        {
            return RouteFlow.Next();
        }

        [RouteFlow(Path = "create-article", Select = When.Done)]
        public ActionResult Done()
        {
            return View();
        }

    }

}
