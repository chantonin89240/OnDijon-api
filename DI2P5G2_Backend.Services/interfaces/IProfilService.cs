using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Services.interfaces
{
    public interface IProfilService
    {
        Profil GetProfilById(int id);
        IEnumerable<Profil> GetAllProfils();
        void CreateProfil(Profil profil);
        void UpdateProfil(Profil profil);
        void DeleteProfil(Profil profil);
    }
}
