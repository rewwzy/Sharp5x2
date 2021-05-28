using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NET105_Tutorial_DI_DepedencyInjection.Controllers
{
    public class StudentController : Controller
    {
        readonly Services.IServices.IStudentService _studentService;
 
        public StudentController(Services.IServices.IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var temp = _studentService.GetAllStudents();
            return View();
        }
    }
}
