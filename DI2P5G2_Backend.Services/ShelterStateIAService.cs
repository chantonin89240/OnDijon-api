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
    public class ShelterStateIAService : IShelterStateIAService
    {
        private readonly IShelterStateIARepository _shelterStateIARepository;

        public ShelterStateIAService(IShelterStateIARepository shelterStateIARepository)
        {
            this._shelterStateIARepository = shelterStateIARepository;
        }

        public void AddShelterState(ShelterStateIA shelterStateIA)
        {
            this._shelterStateIARepository.AddShelterStateIA(shelterStateIA);
        }

        public ShelterStateIA GetStateByShelter(string IdAbris)
        {
            return this._shelterStateIARepository.FindStateByShelter(IdAbris);
        }
    }
}
