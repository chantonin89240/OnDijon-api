using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository.interfaces
{
    public interface IProfilRepository
    {
        Profil GetById(int id);
        IEnumerable<Profil> GetAll();
        void Add(Profil profil);
        void Update(Profil profil);
        void Delete(Profil profil);
    }
}
