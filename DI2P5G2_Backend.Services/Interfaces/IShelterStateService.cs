﻿using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Services.Interfaces
{
    public interface IShelterStateService
    {
        ShelterState GetLastStateByShelter(string IdAbris);
        IEnumerable<ShelterState> GetAll();
        void AddShelterState(ShelterState shelterState);
        int GetStatUserOnShelter(string id, DateTime dateStart, DateTime dateEnd);
    }
}
