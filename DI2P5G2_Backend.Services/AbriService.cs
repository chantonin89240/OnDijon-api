using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.Interfaces;
using DI2P5G2_Backend.Services.Interfaces;

namespace DI2P5G2_Backend.Services
{
    public class AbriService : IAbriService
    {
        private readonly IAbriRepository _abriRepository;

        public AbriService(IAbriRepository abriRepository)
        {
            this._abriRepository = abriRepository;
        }

        public async Task<IEnumerable<Abris>> GetAll()
        {
            return await this._abriRepository.FindAll();
        }

        public async Task<Abris> GetById(string id)
        {
            return await this._abriRepository.Find(id);
        }
    }
}
