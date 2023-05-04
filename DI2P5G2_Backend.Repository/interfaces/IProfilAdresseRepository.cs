using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository.interfaces
{
    public interface IProfilAdresseRepository
    {
        IEnumerable<L_ProfilAdresse> GetAllByProfilId(int id);
        void Add(L_ProfilAdresse profilAdresse);
        void Delete(L_ProfilAdresse profilAdresse);
    }
}
