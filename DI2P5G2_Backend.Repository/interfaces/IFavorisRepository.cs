using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository.interfaces
{
    public interface IFavorisRepository
    {
        Favoris FindById(int id);
        IEnumerable<Favoris> FindByGuid(Guid guid);
        void Add(Favoris favoris);
        void Delete(int id);
        void Update(Favoris? favoris);
    }
}
