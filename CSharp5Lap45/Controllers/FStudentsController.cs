using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSharp5Lap45.Data.EF.DBContext;
using CSharp5Lap45.Data.EF.Entity;
using CSharp5Lap45.Service.IServices;

namespace CSharp5Lap45.Controllers
{
    public class FStudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public FStudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: FStudents
        public async Task<IActionResult> Index()
        {
            var dBContextFPOLY = await _studentService.GetAllStudenModel();
            ViewData["IdClass"] = new SelectList(_studentService.GetAllClassModel().Result, "NameClass", "NameClass");
            return View(dBContextFPOLY);
        }

        // GET: FStudents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["IdClass"] = new SelectList(_studentService.GetAllClassModel().Result, "NameClass", "NameClass");
            var fStudent = await _studentService.Detail((int)id);
            if (fStudent == null)
            {
                return NotFound();
            }

            return View(fStudent);
        }

        // GET: FStudents/Create
        public IActionResult Create()
        {
            ViewData["IdClass"] = new SelectList(_studentService.GetAllClassModel().Result, "NameClass", "NameClass");
            return View();
        }

        // POST: FStudents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StId,Name,Mark,Email,IdClass")] FStudent fStudent)
        {
            if (ModelState.IsValid)
            {
                await _studentService.Add(fStudent);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdClass"] = new SelectList(_studentService.GetAllClassModel().Result, "NameClass", "NameClass", fStudent.IdClass);
            return View(fStudent);
        }

        // GET: FStudents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fStudent = await _studentService.Detail((int)id);
            if (fStudent == null)
            {
                return NotFound();
            }
            ViewData["IdClass"] = new SelectList(_studentService.GetAllClassModel().Result, "NameClass", "NameClass", fStudent.IdClass);
            return View(fStudent);
        }

        // POST: FStudents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StId,Name,Mark,Email,IdClass")] FStudent fStudent)
        {
            if (id != fStudent.StId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _studentService.Edit(fStudent);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FStudentExists(fStudent.StId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdClass"] = new SelectList(_studentService.GetAllClassModel().Result, "NameClass", "NameClass", fStudent.IdClass);
            return View(fStudent);
        }

        // GET: FStudents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fStudent = await _studentService.Detail((int)id);
            if (fStudent == null)
            {
                return NotFound();
            }

            return View(fStudent);
        }

        // POST: FStudents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fStudent = await _studentService.Detail(id);
            await _studentService.Delete(fStudent);
            return RedirectToAction(nameof(Index));
        }

        private bool FStudentExists(int id)
        {
            return _studentService.IsValid(id).Result;
        }
    }
}
