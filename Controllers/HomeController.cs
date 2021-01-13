using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication12.DataRepositories;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class HomeController:Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }



        public ViewResult Details()
        {
            Student model = _studentRepository.GetStudent(1);
            ViewBag.PageTitle = "学生详情";
            
            return View(model);
        }



        //public ViewResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    //将PageTitle和Student模型对象存储在ViewBag
        //    //我们正在使用动态属性PageTitle和Student
        //    ViewBag.PageTitle = "学生详情";
        //    ViewBag.Student = model;
        //    return View();
        //}


        //public ViewResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    //使用ViewData将PageTitle和Student模型传递给View
        //    ViewData["PageTitle"] = "Student Details";
        //    ViewData["Student"] = model;
        //    return View();
        //}


        //public ViewResult Details()
        //{
        //    return View("../Test/Update");
        //}



        //public ViewResult Details()
        //{
        //    return View("/MyViews/Test.cshtml");
        //}



        //public ViewResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    return  View(model);
        //}


        //public ObjectResult Details()
        //{
        //    //遵循内容协商
        //    Student model = _studentRepository.GetStudent(1);
        //    return new ObjectResult(model);

        //}

        //public JsonResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    return Json(model);
        //}
    }
}
