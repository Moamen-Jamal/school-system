﻿using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace SchoolUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdminService adminService;
        public HomeController(AdminService _adminService)
        {
            adminService = _adminService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]


            if (user == null)


            }
        }
    }
}