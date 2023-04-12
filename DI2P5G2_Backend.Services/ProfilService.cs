using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository;
using DI2P5G2_Backend.Repository.interfaces;
using DI2P5G2_Backend.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Services
{
    public class ProfilService : IProfilService
    {
        private readonly IProfilRepository _profilRepository;

        public ProfilService(IProfilRepository profilRepository)
        {
            _profilRepository = profilRepository;
        }

        public Profil GetProfilById(int id)
        {
            return _profilRepository.GetById(id);
        }

        public IEnumerable<Profil> GetAllProfils()
        {
            return _profilRepository.GetAll();
        }

        public void CreateProfil(Profil profil)
        {
            _profilRepository.Add(profil);
        }

        public void UpdateProfil(Profil profil)
        {
            _profilRepository.Update(profil);
        }

        public void DeleteProfil(Profil profil)
        {
            _profilRepository.Delete(profil);
        }
    }

}
