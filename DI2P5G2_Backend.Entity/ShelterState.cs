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
        public string? IdAbris { get; set; }
        public DateTime? DateTimeRefresh { get; set; }
        public int? Available { get; set; }

        public ShelterState() { }

        public ShelterState(int id, string idAbris, DateTime dateTimeRefresh, int available)
        {
            Id = id;
            IdAbris = idAbris;
            DateTimeRefresh = dateTimeRefresh;
            Available = available;

        }
    }
 
}
