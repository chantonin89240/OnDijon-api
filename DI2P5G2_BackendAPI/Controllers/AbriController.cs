using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DI2P5G2_BackendAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AbriController : ControllerBase
    {
        private IAbriService _abriService;

        public AbriController(IAbriService abriService)
        {
            this._abriService = abriService;
        }

        // GET: récupére la liste des abris
        [HttpGet]
        public async Task<IEnumerable<Abris>> Get()
        {
            return await this._abriService.GetAll();
        }

        // GET: récupèration d'un abris
        [HttpGet("{id}")]
        public async Task<Abris> Get(string id)
        {
            return await this._abriService.GetById(id);
        }
    }
}
