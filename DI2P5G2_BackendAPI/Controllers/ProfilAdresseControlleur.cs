using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI2P5G2_BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilAdresseController : ControllerBase
    {
        private readonly IProfilAdresseRepository _profilAdresseRepository;

        public ProfilAdresseController(IProfilAdresseRepository profilAdresseRepository)
        {
            _profilAdresseRepository = profilAdresseRepository;
        }

        // GET: api/<ProfilController>
        [HttpGet]
        public IEnumerable<L_ProfilAdresse> GetAllByProfilId(int id)
        {
            return _profilAdresseRepository.GetAllByProfilId(id);
        }

        // POST api/<ProfilController>
        [HttpPost]
        public void Post([FromBody] L_ProfilAdresse profilAdresse)
        {
            _profilAdresseRepository.Add(profilAdresse);
        }

        // DELETE api/<ProfilController>/5
        [HttpDelete("{id}")]
        public void Delete(L_ProfilAdresse profilAdresse)
        {
            _profilAdresseRepository.Delete(profilAdresse);
        }
    }
}
