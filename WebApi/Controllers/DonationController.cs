using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Models;
using Services.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationController : ControllerBase
    {
        IDonationService _donationService;
        public DonationController(IDonationService donationService)
        {
            _donationService = donationService;
        }
    
        // GET: api/<DonationController>
        [HttpGet]
        public async Task<List<DonationModel>> Get()
        {
            return await _donationService.GetAllAsync();
        }

        // GET api/<DonationController>/5
        [HttpGet("{id}")]
        public async Task<DonationModel> Get(int id)
        {
            return await _donationService.GetByIdAsync(id);
        }

        // POST api/<DonationController>
        [HttpPost]
        public async Task<DonationModel> Post([FromBody] DonationModel donationModel)
        {
            return await _donationService.AddAsync(donationModel);
        }

        // PUT api/<DonationController>/5
        [HttpPut("{id}")]
        public async Task<DonationModel> Put(int id, [FromBody] DonationModel donationModel)
        {
            return await _donationService.UpdateAsync(id, donationModel);
        }

        // DELETE api/<DonationController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _donationService.DeleteAsync(id);           
        }
    }
}
