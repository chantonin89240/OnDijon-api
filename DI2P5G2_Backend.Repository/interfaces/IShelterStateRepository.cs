using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository.interfaces
{
    public interface IShelterStateRepository
    {
        ShelterState FindLastStateByShelter(string IdAbris);
        IEnumerable<ShelterState> GetAll();
        void AddShelterState(ShelterState shelterState);
        int StoredStatUserOnShelter(string id, DateTime dateStart, DateTime dateEnd);
    }
}
