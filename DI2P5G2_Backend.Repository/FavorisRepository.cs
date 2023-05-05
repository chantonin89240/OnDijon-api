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
    public class FavorisRepository : IFavorisRepository
    {
        private readonly DI2P5G2_BackendDbContext _context;

        public FavorisRepository(DI2P5G2_BackendDbContext context)
        {
            _context = context;
        }

         public IEnumerable<Favoris> GetAllByProfilId(int ProfilId)
        {
            return _context.Favoris.ToList().FindAll(pa => pa.ProfilId == ProfilId);
        }

        public void Add(Favoris favoris)
        {
            _context.Favoris.Add(favoris);
            _context.SaveChanges();
        }

         public void Delete(Favoris favoris)
        {
            _context.Favoris.Remove(favoris);
            _context.SaveChanges();
        }
    }
}
