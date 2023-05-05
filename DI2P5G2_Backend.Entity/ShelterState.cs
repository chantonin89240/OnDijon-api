using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Entity
{
    public class ShelterState
    {
        public int? Id { get; set; }
        public int? IdAbris { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? Available { get; set; }
        public ShelterState() { }
        public ShelterState(int id, int idAbris, DateTime timestamp, int available)
        {
            Id = id;
            IdAbris = idAbris;
            Timestamp = timestamp;
            Available = available;

        }
    }
 
}
