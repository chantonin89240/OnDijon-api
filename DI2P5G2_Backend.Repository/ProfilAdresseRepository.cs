using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository 
{
    public class ProfilAdresseRepository : IProfilAdresseRepository
    {
        private readonly DI2P5G2_BackendDbContext _context;

        public ProfilAdresseRepository(DI2P5G2_BackendDbContext context)
        {
            _context = context;
        }

         public IEnumerable<L_ProfilAdresse> GetAllByProfilId(int ProfilId)
        {
            return _context.ProfilAdresse.ToList().FindAll(pa => pa.ProfilId == ProfilId);
        }

        public void Add(L_ProfilAdresse profilAdresse)
        {
            _context.ProfilAdresse.Add(profilAdresse);
            _context.SaveChanges();
        }

         public void Delete(L_ProfilAdresse profilAdresse)
        {
            _context.ProfilAdresse.Remove(profilAdresse);
            _context.SaveChanges();
        }
    }
}
