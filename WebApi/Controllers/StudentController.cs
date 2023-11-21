using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Services.Interfaces;
using Services.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
    
       
        // GET: api/<StudentController>
        [HttpGet]
        public  async Task<List<StudentModel>>Get()
        {
            return await _studentService.GetAllAsync();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<StudentModel> Get(int id)
        {
            return await _studentService.GetByIdAsync(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<StudentModel> Post([FromBody] StudentModel student)
        {
            return await _studentService.AddAsync(student);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<StudentModel> Put(int id, [FromBody] StudentModel student)
        {
            return await _studentService.UpdateAsync(id, student);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _studentService.DeleteAsync(id);
            return Ok();
        }
    }
}
