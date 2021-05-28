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
    public class FClassesController : Controller
    {
        private readonly IClassService _classService;

        public FClassesController(IClassService classService)
        {
            _classService = classService;
        }

        // GET: FClasses
        public async Task<IActionResult> Index()
        {
            return View(await _classService.GetAllClassModel());
        }

        // GET: FClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fClass = await _classService.Detail((int)id);
            if (fClass == null)
            {
                return NotFound();
            }

            return View(fClass);
        }

        // GET: FClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdClass,NameClass")] FClass fClass)
        {
            if (ModelState.IsValid)
            {
                await _classService.Add(fClass);
                return RedirectToAction(nameof(Index));
            }
            return View(fClass);
        }

        // GET: FClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fClass = await _classService.Detail((int)id);
            if (fClass == null)
            {
                return NotFound();
            }
            return View(fClass);
        }

        // POST: FClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdClass,NameClass")] FClass fClass)
        {
            if (id != fClass.IdClass)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _classService.Edit(fClass);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FClassExists(fClass.IdClass))
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
            return View(fClass);
        }

        // GET: FClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fClass =await _classService.Detail((int)id);
            if (fClass == null)
            {
                return NotFound();
            }

            return View(fClass);
        }

        // POST: FClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var fStudent = await _classService.Detail(id);
            await _classService.Delete(fStudent);
            return RedirectToAction(nameof(Index));
        }

        private bool FClassExists(int id)
        {
            return _classService.IsValid((int)id).Result;
        }
    }
}
