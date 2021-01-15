using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Controllers
{
    [Route("[controller]/[action]")]
    public class DepartmentsController:Controller
    {
        public string List()
        {
            return "我是Departments控制器的List()方法";
        }
        
        public string Details()
        {
            return "我是Departments控制器的Details()方法";
        }
    }
}
