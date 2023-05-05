using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DI2P5G2_BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavorisController : ControllerBase
    {
        private readonly IFavorisRepository _favorisRepository;

        public FavorisController(IFavorisRepository favorisRepository)
        {
            _favorisRepository = favorisRepository;
        }

        // GET: api/<ProfilController>
        [HttpGet]
        public IEnumerable<Favoris> GetAllByProfilId(int id)
        {
            return _favorisRepository.GetAllByProfilId(id);
        }

        // POST api/<ProfilController>
        [HttpPost]
        public void Post([FromBody] Favoris favoris)
        {
            _favorisRepository.Add(favoris);
        }

        // DELETE api/<ProfilController>/5
        [HttpDelete("{id}")]
        public void Delete(Favoris favoris)
        {
            _favorisRepository.Delete(favoris);
        }
    }
}
