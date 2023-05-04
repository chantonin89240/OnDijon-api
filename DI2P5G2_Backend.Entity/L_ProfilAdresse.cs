using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Entity
{
    public class L_ProfilAdresse
    {
        public int? Id { get; set; }
        public int? ProfilId { get; set; }
        public int? AdresseId { get; set; }
        public bool? Favori { get; set; }
        public L_ProfilAdresse()
        {

        }

        public L_ProfilAdresse(int id, int idProfil, int idAdresse, bool favori)
        {
            Id = id;
            ProfilId = idProfil;
            AdresseId = idAdresse;
            Favori = favori;
        }

    }
}
