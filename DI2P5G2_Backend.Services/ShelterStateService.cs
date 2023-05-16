using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;
using DI2P5G2_Backend.Repository.Interfaces;
using DI2P5G2_Backend.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Services
{
    public class ShelterStateService : IShelterStateService
    {
        private readonly IShelterStateRepository _shelterStateRepository;

        public ShelterStateService(IShelterStateRepository shelterStateRepository)
        {
            this._shelterStateRepository = shelterStateRepository;
        }

        public void AddShelterState(ShelterState shelterState)
        {
            this._shelterStateRepository.AddShelterState(shelterState);
        }

        public ShelterState GetLastStateByShelter(int IdAbris)
        {
            return this._shelterStateRepository.FindLastStateByShelter(IdAbris);
        }

        public int GetStatUserOnShelter(string id, DateTime dateStart, DateTime dateEnd)
        {
            return this._shelterStateRepository.StoredStatUserOnShelter(id, dateStart, dateEnd);
        }
    }
}
