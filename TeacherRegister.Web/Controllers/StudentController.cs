using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeacherRegister.BLL;
using TeacherRegister.DAL.EF;

namespace TeacherRegister.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Student> students = _context.Student.ToList();
            return View(students);
        }
    }
}