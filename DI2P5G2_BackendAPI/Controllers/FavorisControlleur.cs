using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DI2P5G2_BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavorisController : ControllerBase
    {
        private IFavorisService _favorisService;

        public FavorisController(IFavorisService favoriService)
        {
            this._favorisService = favoriService;
        }

        // GET: récupére la liste des favoris pour un utilisateur 
        [HttpGet("byGuid/{guid}")]
        public IEnumerable<Favoris> GetFavorisByGuid(Guid guid)
        {
            return _favorisService.GetFavorisByGuid(guid);
        }

        [HttpGet("{id}")]
        public Favoris GetFavorisById(int id)
        {
            return _favorisService.GetFavorisById(id);
        }

        // POST: ajout d'un favoris pour un utilisateur 
        [HttpPost]
        public void Post([FromBody] Favoris favoris)
        {
            _favorisService.AddFavoris(favoris);
        }

        // DELETE: suppression d'un favoris
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _favorisService.DeleteFavoris(id);
        }

        // PUT: modification d'un favoris
        [HttpPut]
        public void Update(Favoris favoris)
        {
            _favorisService.UpdateFavoris(favoris);
        }
    }
}
