using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        // repository pour récupérer un favoris
        public Favoris FindById(int id)
        {
            return _context.Favoris.Find(id);
        }

        // repository pour récupérer la liste des favoris d'un utilisateur
        public IEnumerable<Favoris> FindByGuid(Guid guid)
        {
            Profil idProfil = _context.Profil.Find(guid);
            return _context.Favoris.ToList().FindAll(fa => fa.ProfilId == idProfil.Id);

            //return _context.Favoris.ToList().Join(_context.Profil, fav => fav.ProfilId, pro => pro.Guid, (fav, pro) = fav);
        }

        // repository pour ajouter un favoris
        public void Add(Favoris favoris)
        {
            _context.Favoris.Add(favoris);
            _context.SaveChanges();
        }

        // repository pour supprimer un favoris
        public void Delete(int id)
        {
            var favoris = this._context.Favoris.First(s => s.Id == id);
            _context.Favoris.Remove(favoris);
            _context.SaveChanges();
        }

        // repository pour modifier un favoris
        public void Update(Favoris favoris)
        {
            _context.Favoris.Update(favoris);
            _context.SaveChanges();
        }
    }
}
