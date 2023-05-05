using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Entity
{
    public class SensorError
    {
        public int? Id { get; set; }
        public int? IdAbris { get; set; }
        public int? IdCapteur{ get; set; }
        public string? Libelle{ get; set; }
        public SensorError() { }
        public SensorError(int id, int idAbris, int idCapteur, string libelle)
        {
            Id = id;
            IdAbris = idAbris;
            IdCapteur = idCapteur;
            Libelle = libelle;

        }
    }
}
