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
        ShelterState GetById(int id);
        IEnumerable<ShelterState> GetAll();
        void Add(ShelterState shelter);
        void Update(ShelterState shelter);
        void Delete(ShelterState shelter);
    }
}
