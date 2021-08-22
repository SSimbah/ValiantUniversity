using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValiantUniversity.Data;
using ValiantUniversity.Models;

namespace ValiantUniversity.Controllers
{
    public class InstructorController : Controller
    {
        private readonly DatabaseDbContext _context;
        public InstructorController(DatabaseDbContext context) 
        {
            _context = context;
        }
        // GET: Instructor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Instructor.ToListAsync());
        }

        // GET: Create Instructor
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instructor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName, InstructorEmail, InstructorPassword, Gender, Age")] Instructor instructor) 
        {
            if (ModelState.IsValid)
            {
                _context.Add(instructor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instructor);
        }

        // GET: Instructor Details
        public async Task<IActionResult> Details(int? id) 
        {
            if (id == null) 
            {
                return NotFound();
            }
            var instructor = await _context.Instructor.FirstOrDefaultAsync();
            if(instructor == null) 
            {
                return NotFound();
            }
            return View(instructor);
        }
    }
}
