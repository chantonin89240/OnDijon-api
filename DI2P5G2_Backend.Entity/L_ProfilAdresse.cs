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
        public int? IdProfil { get; set; }
        public int? IdAdresse { get; set; }
        public bool? Favori { get; set; }

        public L_ProfilAdresse()
        {

        }

        public L_ProfilAdresse(int id, int idProfil, int idAdresse, bool favori)
        {
            Id = id;
            IdProfil = idProfil;
            IdAdresse = idAdresse;
            Favori = favori;
        }

    }
}
