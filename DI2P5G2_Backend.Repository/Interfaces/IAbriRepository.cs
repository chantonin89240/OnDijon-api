using DI2P5G2_Backend.Entity;

namespace DI2P5G2_Backend.Repository.Interfaces
{
    public interface IAbriRepository
    {
        Task<Abris> Find(string id);
        Task<IEnumerable<Abris>> FindAll();
    }
}
