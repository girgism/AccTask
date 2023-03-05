using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccFlex.Models;
using NToastNotify;

namespace AccFlex.Controllers
{
    public class StudentCoursesController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IToastNotification _toastNotification;

        public StudentCoursesController(ApplicationDBContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        // GET: StudentCourses
        public async Task<IActionResult> Index()
        {
            var getAll = _context.StudentCourse.Include(s => s.Course).Include(s => s.Student);
            return View(await getAll.ToListAsync());
        }

        // GET: StudentCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var studentCourse = await _context.StudentCourse
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.CourseID == id);

            if (studentCourse == null)
                return NotFound();

            return View(studentCourse);
        }

        // GET: StudentCourses/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name");
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Name");
            return View();
        }

        // POST: StudentCourses/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentCourse studentCourse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentCourse);
                await _context.SaveChangesAsync();
                _toastNotification.AddSuccessToastMessage("Assigned Successfully");
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", studentCourse.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Name", studentCourse.StudentID);
            return View(studentCourse);
        }

        // GET: StudentCourses/Edit/5
        public async Task<IActionResult> Edit(StudentCourse studentIn)
        {
            if (studentIn == null)
                return NotFound();

            var studentCourse = await _context.StudentCourse
                .Include(m=>m.Course)
                .Include(m=>m.Student)
                .FirstOrDefaultAsync(
                    m => m.CourseID == studentIn.CourseID
                    && m.StudentID == studentIn.StudentID);

            if (studentCourse == null)
                return NotFound();

            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", studentCourse.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Name", studentCourse.StudentID);
            return View(studentCourse);
        }

        // POST: StudentCourses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,StudentCourse studentCourse)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentCourseExists(studentCourse.CourseID))
                        return NotFound();
                    else
                        throw;
                }
                _toastNotification.AddSuccessToastMessage("Assigned Successfully");
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Name", studentCourse.CourseID);
            ViewData["StudentID"] = new SelectList(_context.Students, "ID", "Name", studentCourse.StudentID);
            return View(studentCourse);
        }

        // GET: StudentCourses/Delete/5
        public async Task<IActionResult> Delete(StudentCourse studentIn)
        {
            if (studentIn == null)
                return NotFound();

            var studentCourse = await _context.StudentCourse
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(
                    m => m.CourseID == studentIn.CourseID 
                    && m.StudentID == studentIn.StudentID);

            if (studentCourse == null)
                return NotFound();

            _context.StudentCourse.Remove(studentCourse);
            await _context.SaveChangesAsync();
            _toastNotification.AddErrorToastMessage("Deleted Successfully");

            return RedirectToAction(nameof(Index));
        }

       
        private bool StudentCourseExists(int id)
        {
            return _context.StudentCourse.Any(e => e.CourseID == id);
        }
    }
}
