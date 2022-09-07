using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.ClassLibrary.Models;
using School.School.API.RepositoryPattern;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.School.API.Controllers
{
    //[Authorize]

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsAPIController : ControllerBase
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentsAPIController(IRepository<Student> studentRepository)
        {
            this._studentRepository = studentRepository;
        }
        // GET: api/<StudentsController>
        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }
        
        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(int id)
        {
            var result = await _studentRepository.GetSingleStudent(id);
            if(result == null)
            {
                return StatusCode(404, result);
            }
            return result;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public async Task<ActionResult<Student>> Post(Student student)
        {
            if(student != null)
            {
               await _studentRepository.CreateStudent(student);
                return Ok(student);
            }
            return StatusCode(500, student);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> Put(int id, Student student)
        {
            var result = await _studentRepository.GetSingleStudent(id);
            if(result != null)
            {
               result.FirstName = student.FirstName;
                result.LastName = student.LastName;
               await _studentRepository.UpdateStudent(id, result);
                return result;
            }
            return null;
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public async Task <ActionResult> Delete(int id)
        {
            var result = await _studentRepository.GetSingleStudent(id);
            if(result != null)
            {
                 await _studentRepository.DeleteStudentAsync(id);
                return Ok();
            }
            return StatusCode(404, "There is no student with this id");
        }
    }
}
