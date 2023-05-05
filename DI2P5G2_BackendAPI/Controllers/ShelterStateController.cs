using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DI2P5G2_BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelterStateController : ControllerBase
    {
        private readonly IShelterStateRepository _shelterStateRepository;

        public ShelterStateController(IShelterStateRepository shelterStateRepository)
        {
            _shelterStateRepository = shelterStateRepository;
        }

        // GET: api/<ShelterStateController>
        [HttpGet]
        public IEnumerable<ShelterState> Get()
        {
            return _shelterStateRepository.GetAll();
        }

        // GET api/<ShelterStateController>/5
        [HttpGet("{id}")]
        public ShelterState Get(int id)
        {
            return _shelterStateRepository.GetById(id);
        }

        // POST api/<ShelterStateController>
        [HttpPost]
        public void Post([FromBody] ShelterState shelter)
        {
            _shelterStateRepository.Add(shelter);
        }

        // PUT api/<ShelterStateController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] ShelterState shelter)
        {
            _shelterStateRepository.Update(shelter);
        }

        // DELETE api/<ShelterStateController>/5
        [HttpDelete("{id}")]
        public void Delete(ShelterState shelter)
        {
            _shelterStateRepository.Delete(shelter);
        }
    }
}
