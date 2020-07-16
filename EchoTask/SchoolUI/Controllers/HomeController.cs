using Services;
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

        [HttpGet]        public ActionResult Login()        {            return View();        }        [HttpPost]        public ActionResult Login(AdminEditViewModel admin)        {            AdminViewModel user = adminService.GetAll().                FirstOrDefault(i => i.UserName == admin.UserName                && i.Password == admin.Password);            if (!ModelState.IsValid)            {                if (admin.UserName == "" || admin.UserName == null)                    ViewBag.UserName = "this field is required";                if (admin.Password == "" || admin.Password == null)                    ViewBag.Password = "this field is required";                return View();            }


            if (user == null)            {                ViewBag.IsAdmin = "This Account Is Not Correct";                return View();            }            else            {                Session["log"] = user;                return RedirectToAction("ClassRoom", "ClassRoom", null);


            }
        }
    }
}