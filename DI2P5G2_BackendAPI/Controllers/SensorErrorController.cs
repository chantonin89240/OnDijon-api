using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DI2P5G2_BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorErrorController : ControllerBase
    {
        private readonly ISensorErrorRepository _sensorErrorRepository;

        public SensorErrorController(ISensorErrorRepository sensorErrorRepository)
        {
            _sensorErrorRepository = sensorErrorRepository;
        }

        // GET: api/<SensorErrorController>
        [HttpGet]
        public IEnumerable<SensorError> Get()
        {
            return _sensorErrorRepository.GetAll();
        }

        // GET api/<SensorErrorController>/5
        [HttpGet("{id}")]
        public SensorError Get(int id)
        {
            return _sensorErrorRepository.GetById(id);
        }

        // POST api/<SensorErrorController>
        [HttpPost]
        public void Post([FromBody] SensorError sensor)
        {
            _sensorErrorRepository.Add(sensor);
        }

        // PUT api/<SensorErrorController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] SensorError sensor)
        {
            _sensorErrorRepository.Update(sensor);
        }

        // DELETE api/<SensorErrorController>/5
        [HttpDelete("{id}")]
        public void Delete(SensorError sensor)
        {
            _sensorErrorRepository.Delete(sensor);
        }
    }
}
