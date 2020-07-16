using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModels;

namespace SchoolUI.Controllers
{
    public class ClassLessonController : Controller
    {


        private readonly ClassLessonService ClassLessonService;
        
        public ClassLessonController(ClassLessonService _ClassLessonService)
        {
            ClassLessonService = _ClassLessonService;
            
        }
        // GET: Home
        public ActionResult ClassLesson()
        {
            if (Session["log"] == null)
                return RedirectToAction("Login", "Home", null);
            var ClassLessons = ClassLessonService.GetAll().ToList();
            return View(ClassLessons);
        }

        public ActionResult Details(int id)
        {

            if (Session["log"] == null)
                return RedirectToAction("Login", "Home", null);
            ClassLessonViewModel ClassLesson = ClassLessonService.GetByID(id);
            return View(ClassLesson);
        }

        public ActionResult Add()
        {
            if (Session["log"] == null)
                return RedirectToAction("Login", "Home", null);
            
            return View();
        }
        [HttpPost]
        public ActionResult Add(ClassLessonEditViewModel ClassLesson)
        {
            if (!ModelState.IsValid)
            {
               
                return View();
            }

            ClassLessonService.Add(ClassLesson);
            return RedirectToAction("ClassLesson");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ClassLessonService.Remove(id);
            return RedirectToAction("ClassLesson");
        }
        public ActionResult Update(int id)
        {
            if (Session["log"] == null)
                return RedirectToAction("Login", "Home", null);
            var ClassLesson = ClassLessonService.GetByID(id);
           
            return View(ClassLesson);
        }
        [HttpPost]
        public ActionResult Update(ClassLessonEditViewModel ClassLesson)
        {
            if (!ModelState.IsValid)
            {
                
                return View();
            }

            ClassLessonService.Update(ClassLesson);
            return RedirectToAction("ClassLesson");
        }
    }
}