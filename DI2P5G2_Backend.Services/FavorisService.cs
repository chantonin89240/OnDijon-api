using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using DI2P5G2_Backend.Services.Interfaces;

namespace DI2P5G2_Backend.Services
{
    public class FavorisService : IFavorisService
    {
        private readonly IFavorisRepository _favorisRepository;

        // service pour l'ajout d'u favoris
        public void AddFavoris(Favoris favoris)
        {
            _favorisRepository.Add(favoris);
        }

        // service pour la suppression d'un favoris
        public void DeleteFavoris(int id)
        {
            _favorisRepository.Delete(id);
        }

        // service pour récupérer les favoris d'un utilisateur
        public Favoris GetFavoris(int id)
        {
            return _favorisRepository.FindById(id);
        }

        // service pour récupérer un favoris pour un utilisateur
        public IEnumerable<Favoris> GetFavorisByGuid(Guid guid)
        {
            return _favorisRepository.FindByGuid(guid);
        }

        // service pour modifier un favoris
        public void UpdateFavoris(Favoris favoris)
        {
            _favorisRepository.Update(favoris);
        }
    }
}
