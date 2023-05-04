using DI2P5G2_Backend.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DI2P5G2_Backend.EntitiesContext
{
    public class DI2P5G2_BackendDbContext : DbContext
    {
        public DbSet<Profil>? Profil { get; set; }
        public DbSet<L_ProfilAdresse>? ProfilAdresse { get; set; }

        public DI2P5G2_BackendDbContext(DbContextOptions<DI2P5G2_BackendDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
