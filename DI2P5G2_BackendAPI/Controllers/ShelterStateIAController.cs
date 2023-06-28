using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DI2P5G2_BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelterStateIAController
    {
        private readonly IShelterStateIAService _shelterStateIAService;

        public ShelterStateIAController(IShelterStateIAService shelterStateIAService)
        {
            this._shelterStateIAService = shelterStateIAService;
        }
            // GET api/<ShelterStateIAController>/5
            [HttpGet("{id}")]
            public ShelterStateIA GetStateByShelter(string id)
            {
                return this._shelterStateIAService.GetStateByShelter(id);
            }

            // POST api/<ShelterStateIAController>
            [HttpPost]
            [Route("StateIA")]
            public void Post([FromBody] ShelterStateIA shelterIA)
            {
                this._shelterStateIAService.AddShelterState(shelterIA);
            }
        }
}
