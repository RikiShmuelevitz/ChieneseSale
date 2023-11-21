using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        IClassService _classService;
        public ClassController(IClassService classRepository)
        {
            _classService = classRepository;
        }

        // GET: api/<ClassController>
        [HttpGet]
        public async Task<List<ClassModel>> Get()
        {
            return await _classService.GetAllAsync();
        }

        // GET api/<ClassController>/5
        [HttpGet("{id}")]
        public async Task<ClassModel> Get(int id)
        {
            return await _classService.GetByIdAsync(id);
        }

        // POST api/<ClassController>
        [HttpPost]
        public async Task<ClassModel> Post([FromBody] ClassModel classModel)
        {
            return await _classService.AddAsync(classModel);
        }

        // PUT api/<ClassController>/5
        [HttpPut("{id}")]
        public async Task<ClassModel> Put(int id, [FromBody] ClassModel classModel)
        {
            return await _classService.UpdateAsync(id, classModel);
        }

        // DELETE api/<ClassController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _classService.DeleteAsync(id);
        }
    }
}
