﻿using DI2P5G2_Backend.EntitiesContext;
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

        public IEnumerable<ShelterState> GetAll()
        {
            return _context.ShelterState.ToList();
        }

        public ShelterState FindLastStateByShelter(string IdAbris)
        {
            return this._context.ShelterState.OrderBy(a => a.Id).Last(a => a.IdAbris == IdAbris);
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
