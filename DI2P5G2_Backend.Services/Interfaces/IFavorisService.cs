using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Services.Interfaces
{
    public interface IFavorisService
    {
        Favoris GetFavorisById(int id);
        IEnumerable<Favoris> GetFavorisByGuid(Guid guid);
        void AddFavoris(Favoris favoris);
        void DeleteFavoris(int id);
        void UpdateFavoris(Favoris favoris);
    }
}
