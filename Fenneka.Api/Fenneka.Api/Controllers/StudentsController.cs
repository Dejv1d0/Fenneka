using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fenneka.Api.Data;
using Fenneka.Api.Models;

namespace Fenneka.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly TutorAppDbContext _context;

        public StudentsController(TutorAppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _context.Students.ToList();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(student => student.Id == id);

            if (student == null)
            {
                return NotFound();
            }
            
            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _context.Students.Add(student);

            try
            {
                _context.SaveChanges();
                return Ok(student);
            }
            catch (DbUpdateException)
            {
                return BadRequest("Nie udalo sie zapisac danych do bazy.");
            }
        }

        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(student =>student.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            _context.SaveChanges();

            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = _context.Students.FirstOrDefault(student => student.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            student.Name = updatedStudent.Name;
            student.Email = updatedStudent.Email;

            _context.SaveChanges();

            return Ok(student);
        }
    }
}
