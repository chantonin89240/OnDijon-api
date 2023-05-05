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
    public class SensorErrorRepository : ISensorErrorRepository
    {
        private readonly DI2P5G2_BackendDbContext _context;

        public SensorErrorRepository(DI2P5G2_BackendDbContext context)
        {
            _context = context;
        }

        public SensorError GetById(int id)
        {
            return _context.SensorError.FirstOrDefault(sensor => sensor.Id == id);
        }

        public IEnumerable<SensorError> GetAll()
        {
            return _context.SensorError.ToList();
        }

        public void Add(SensorError sensor)
        {
            _context.SensorError.Add(sensor);
            _context.SaveChanges();
        }

        public void Update(SensorError sensor)
        {
            _context.Entry(sensor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(SensorError sensor)
        {
            _context.SensorError.Remove(sensor);
            _context.SaveChanges();
        }
    }
}
