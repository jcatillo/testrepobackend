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
                return NotFound();
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

    }
}
