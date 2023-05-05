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
    public class ShelterStateRepository : IShelterStateRepository
    {
        private readonly DI2P5G2_BackendDbContext _context;

        public ShelterStateRepository(DI2P5G2_BackendDbContext context)
        {
            _context = context;
        }

        public ShelterState GetById(int id)
        {
            return _context.ShelterState.FirstOrDefault(shelter => shelter.Id == id);
        }

        public IEnumerable<ShelterState> GetAll()
        {
            return _context.ShelterState.ToList();
        }

        public void Add(ShelterState shelter)
        {
            _context.ShelterState.Add(shelter);
            _context.SaveChanges();
        }

        public void Update(ShelterState shelter)
        {
            _context.Entry(shelter).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(ShelterState shelter)
        {
            _context.ShelterState.Remove(shelter);
            _context.SaveChanges();
        }
    }
}
