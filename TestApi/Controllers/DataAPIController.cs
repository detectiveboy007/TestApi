﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    public class DataAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}