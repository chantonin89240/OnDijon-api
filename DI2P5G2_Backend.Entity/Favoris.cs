using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Entity
{
    public class Favoris
    {
        public int? Id { get; set; }
        public int? ProfilId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? CodePostal { get; set; }
        public string? Ville { get; set; }
        public string? Rue { get; set; }
        public string? Pays { get; set; }

        public Favoris()
        {

        }

        public Favoris(int id, int idProfil, double latitude, double longitude)
        {
            Id = id;
            ProfilId = idProfil;
            Latitude = latitude;
            Longitude = longitude;
        }

    }
}
