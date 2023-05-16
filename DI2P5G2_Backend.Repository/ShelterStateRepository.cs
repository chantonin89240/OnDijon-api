using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using Microsoft.Data.SqlClient;
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
            this._context = context;
        }

        public ShelterState FindLastStateByShelter(int IdAbris)
        {
            return this._context.ShelterState.Last();
        }

        public void AddShelterState(ShelterState shelterState)
        {
            this._context.ShelterState.Add(shelterState);
            this._context.SaveChanges();
        }

        public int StoredStatUserOnShelter(string id, DateTime dateStart, DateTime dateEnd)
        {
            return this._context.ShelterState.Where(shelter => shelter.IdAbris == id).Where(shelter => shelter.DateTimeRefresh >= dateStart).Where(shelter => shelter.DateTimeRefresh <= dateEnd).Count();
        }
    }
}
