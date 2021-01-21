using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication12.DataRepositories;
using WebApplication12.Models;
using WebApplication12.ViewModels;

namespace WebApplication12.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        //使用构造函数注入的方式注入IStudentRepository
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult  Create(Student student)
        {
           if (ModelState.IsValid)
            {
                Student newStudent = _studentRepository.Add(student);
                return RedirectToAction("Details", new { id = newStudent.ID });
            }
            return View();
        }
      
       


        //返回学生的信息
        public ViewResult Index()
        {
            //查询所有的学生信息
            IEnumerable<Student> students = _studentRepository.GetAllStudents();
            //将学生列表传递到视图
            return View(students);
        }


        //?使路由模板中的id参数为可选，如果要让它为必选，删除？即可
      
        public ViewResult Details(int? id)
        {
            //实例化HomeDetailsViewModel并存储Student详细信息和PageTitle
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.GetStudent(id??1),
                PageTitle = "学生详情"
            };
            //将ViewModel对象传递给View()方法
            return View(homeDetailsViewModel);
        }



        //public ViewResult Details()
        //{
        //    Student model = _studentRepository.GetStudent(1);
        //    ViewBag.PageTitle = "学生详情";
            
        //    return View(model);
        //}



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
