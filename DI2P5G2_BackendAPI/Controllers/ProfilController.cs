using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DI2P5G2_BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilController : ControllerBase
    {
        private readonly IProfilRepository _profilRepository;


        public ProfilController(IProfilRepository profilRepository)
        {
            _profilRepository = profilRepository;
        }

        // GET: api/<ProfilController>
        [HttpGet]
        public IEnumerable<Profil> Get()
        {
            return _profilRepository.GetAll();
        }

        // GET api/<ProfilController>/5
        [HttpGet("{id}")]
        public Profil Get(int id)
        {
            return _profilRepository.GetById(id);
        }

        // POST api/<ProfilController>
        [HttpPost]
        public void Post([FromBody] Profil profil)
        {
            _profilRepository.Add(profil);
        }

        // PUT api/<ProfilController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Profil profil)
        {
            _profilRepository.Update(profil);
        }

        // DELETE api/<ProfilController>/5
        [HttpDelete("{id}")]
        public void Delete(Profil profil)
        {
            _profilRepository.Delete(profil);
        }
    }
}
