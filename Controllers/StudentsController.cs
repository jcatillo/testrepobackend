using backend.Context;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly CspsContext cspsContext;

        public StudentsController(ILogger<StudentsController> logger, CspsContext csps)
        {
            _logger = logger;
            cspsContext = csps;
        }

        [HttpGet(Name = "GetStudents")]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            var students = await cspsContext.Students.ToListAsync();
            return Ok(students);
        }

        [HttpGet("{studentId}", Name = "GetStudentsByStudentId")]
        public async Task<ActionResult<IEnumerable<Student>>> Get(string studentId)
        {
            var student = await cspsContext.Students.FirstOrDefaultAsync(s => s.StudentId == studentId);

            if (student == null)
            {
                return NotFound($"Student with ID {studentId} not found.");
            }

            return Ok(student);
        }

        [HttpPost("addStudent", Name = "AddStudent")]
        public async Task<ActionResult<Student>> Post([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Student data is null.");
            }

            try
            {
                cspsContext.Students.Add(student);
                await cspsContext.SaveChangesAsync();

                return Created($"/students/{student.Id}", student);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("delete/{studentId}", Name = "DeleteStudentByStudentId")]
        public async Task<ActionResult> Delete(string studentId)
        {
            if (string.IsNullOrWhiteSpace(studentId))
            {
                return BadRequest("Student ID cannot be null or empty.");
            }

            var student = await cspsContext.Students.FirstOrDefaultAsync(s => s.StudentId == studentId);

            if (student == null)
            {
                return NotFound($"Student with ID {studentId} not found.");
            }

            try
            {
                cspsContext.Students.Remove(student);
                await cspsContext.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
