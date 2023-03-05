using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccFlex.Models;

namespace AccFlex.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public StudentsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var applicationDBContext = _context.Students.Include(s => s.Class).Include(s => s.Gender);
            return View(await applicationDBContext.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Students
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .FirstOrDefaultAsync(m => m.ID == id);

            student.StudentCourses = await _context.StudentCourse
                .Where(s => s.StudentID == id)
                .Include(s => s.Course)
                .ToListAsync();

            if (student == null)
                return NotFound();

            int age = 0;
            age = DateTime.Now.Year - student.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < student.DateOfBirth.DayOfYear)
                age = age - 1;
            ViewBag.age = age;

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            ViewData["ClassID"] = new SelectList(_context.Classes, "ID", "Name");
            ViewData["GenderID"] = new SelectList(_context.Genders, "ID", "Name");
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["GenderID"] = new SelectList(_context.Genders, "ID", "Name", student.GenderID);
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Students.FindAsync(id);
            if (student == null)
                return NotFound();

            ViewData["ClassID"] = new SelectList(_context.Classes, "ID", "Name", student.ClassID);
            ViewData["GenderID"] = new SelectList(_context.Genders, "ID", "Name", student.GenderID);
            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,DateOfBirth,GenderID,ClassID")] Student student)
        {
            if (id != student.ID)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.ID))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassID"] = new SelectList(_context.Classes, "ID", "Nmae", student.ClassID);
            ViewData["GenderID"] = new SelectList(_context.Genders, "ID", "Name", student.GenderID);
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var student = await _context.Students
                .Include(s => s.Class)
                .Include(s => s.Gender)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
                return NotFound();

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.ID == id);
        }
    }
}
