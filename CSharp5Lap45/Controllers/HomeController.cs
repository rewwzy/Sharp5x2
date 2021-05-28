using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp5Lap45.Service.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CSharp5Lap45.Controllers
{
    public class HomeController : Controller
    {
        readonly IClassService _classService;
        public HomeController(IClassService classService)
        {
            _classService = classService;
        }
        public IActionResult Index()
        {
            var data = _classService.GetAllClassModel();
            return View();
        }

    }
}
