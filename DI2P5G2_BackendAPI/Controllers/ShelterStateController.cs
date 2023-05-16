using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository;
using DI2P5G2_Backend.Repository.interfaces;
using DI2P5G2_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DI2P5G2_BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelterStateController : ControllerBase
    {
        private readonly IShelterStateService _shelterStateService;

        public ShelterStateController(IShelterStateService shelterStateService)
        {
            this._shelterStateService = shelterStateService;
        }

        // GET api/<ShelterStateController>/5
        [HttpGet("{id}")]
        public ShelterState GetLastState(int id)
        {
            return this._shelterStateService.GetLastStateByShelter(id);
        }

        // POST api/<ShelterStateController>
        [HttpPost]
        [Route("State")]
        public void Post([FromBody] ShelterState shelter)
        {
            this._shelterStateService.AddShelterState(shelter);
        }

        // POST api/<ShelterStateController>
        [HttpPost]
        [Route("Stat")]
        public int GetStatUser([FromBody] ShelterStatistique shelter)
        {
            return this._shelterStateService.GetStatUserOnShelter(shelter.Id, shelter.DateStart, shelter.DateEnd);
        }
    }
}
