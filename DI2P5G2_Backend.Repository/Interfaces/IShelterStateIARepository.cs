using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository.Interfaces
{
    public interface IShelterStateIARepository
    {
        ShelterStateIA FindStateByShelter(string IdAbris);
        void AddShelterStateIA(ShelterStateIA shelterStateIA);
    }
}
