﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExampleTutorialGitHub.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Chú thích thêm
        /// </summary>
        /// <returns></returns>
        public ActionResult ABC()
        {
            return View();
        }


    }
}