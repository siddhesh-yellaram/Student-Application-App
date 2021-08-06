using StudentApplicationApp.Model;
using StudentApplicationApp.Models;
using StudentApplicationApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApplicationApp.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Student Details page.";
            return View();
        }
        
        [HttpPost]
        [ActionName("Add")]
        public ActionResult AddPost(AddViewModel vm)
        {
            _service.AddStudent(new Student { Name = vm.Name, RollNo = vm.RollNo, Cgpa = vm.Cgpa });
            return RedirectToAction("Index");
        }

        public ActionResult Display()
        {
            ViewBag.Message = _service.Count();
            return View(_service.Get());
        }

        public void PreUpdate(string id)
        {
            UpdateViewModel vm = new UpdateViewModel();
            vm.Id = id;
            Session["Id"] = id;
            ViewBag.Message = "Student Update page.";
            Response.Redirect("~/Student/Update/" + id);
        }

        public ActionResult Update()
        {
            UpdateViewModel vm = new UpdateViewModel();
            string id = Session["Id"].ToString();
            Student s = _service.GetStudentById(id);
            vm.Id = s.ID;
            vm.Name = s.Name;
            vm.RollNo = s.RollNo;
            vm.Cgpa = s.Cgpa;
            ViewBag.Message = "Student update page.";
            return View(vm);
        }

        [HttpPost]
        [ActionName("Update")]
        public ActionResult UpdatePost(AddViewModel vm)
        {
            string id = Session["Id"].ToString();
            _service.EditStudent(id, new Student { Name = vm.Name, RollNo = vm.RollNo, Cgpa = vm.Cgpa });
            ViewBag.Message = "Student update page.";
            return RedirectToAction("Display", "Student");
        }
    }
}