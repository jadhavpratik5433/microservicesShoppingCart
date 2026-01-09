using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectMMVC.Models;
using ProjectMMVC.Services;
//using ProjectMMVC.Services.Interfaces;

namespace ProjectMMVC.Controllers
{
    public class StudentsClassController : Controller
    {
        private readonly IStudent _studentsService;

        // ✅ DI via Interface
        public StudentsClassController(IStudent studentsService)
        {
            _studentsService = studentsService;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var students = await _studentsService.GetAllAsync();
            return View(students);
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _studentsService.GetByIdAsync(id.Value);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentsClass student)
        {
            if (ModelState.IsValid)
            {
                await _studentsService.CreateAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _studentsService.GetByIdAsync(id.Value);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StudentsClass student)
        {
            if (id != student.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    await _studentsService.UpdateAsync(student);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_studentsService.Exists(student.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _studentsService.GetByIdAsync(id.Value);

            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _studentsService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
