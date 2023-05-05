using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository.interfaces
{
    public interface ISensorErrorRepository
    {
        SensorError GetById(int id);
        IEnumerable<SensorError> GetAll();
        void Add(SensorError sensor);
        void Update(SensorError sensor);
        void Delete(SensorError sensor);
    }
}
