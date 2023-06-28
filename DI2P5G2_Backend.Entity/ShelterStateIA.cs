using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Entity
{
    public class ShelterStateIA
    {
        public int? Id { get; set; }
        public string? IdAbris { get; set; }
        public DateTime? DateTimeRefresh { get; set; }
        public int? TotalVelo { get; set; }

        public ShelterStateIA() { }

        public ShelterStateIA(int id, string idAbris, DateTime dateTimeRefresh, int totalVelo)
        {
            Id = id;
            IdAbris = idAbris;
            DateTimeRefresh = dateTimeRefresh;
            TotalVelo = totalVelo;
        }
    }
}
