using Microsoft.AspNetCore.Mvc;
using Sharp5x2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sharp5x2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public string CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                return "Tạo thành công";
            }
            return "Tạo không thành công";
        }
    }
}
