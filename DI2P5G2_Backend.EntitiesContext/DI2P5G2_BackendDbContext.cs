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
        public DbSet<Profil> Profils { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<L_ProfilAdresse> LinkedAdresses{ get; set; }

        public DI2P5G2_BackendDbContext(DbContextOptions<DI2P5G2_BackendDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Profil>().HasKey(x => x.Id);
        }

    }
}
