namespace DI2P5G2_Backend.Repository
{
    using DI2P5G2_Backend.EntitiesContext;
    using DI2P5G2_Backend.Entity;
    using DI2P5G2_Backend.Repository.Interfaces;

    public class ShelterStateIARepository : IShelterStateIARepository
    {
        private readonly DI2P5G2_BackendDbContext _context;

        public ShelterStateIARepository(DI2P5G2_BackendDbContext context)
        {
            this._context = context;
        }

        public void AddShelterStateIA(ShelterStateIA shelterStateIA)
        {
            this._context.ShelterStateIA.Add(shelterStateIA);
            this._context.SaveChanges();
        }

        public ShelterStateIA FindStateByShelter(string IdAbris)
        {
            return this._context.ShelterStateIA.OrderBy(a => a.Id).Last(a => a.IdAbris == IdAbris);
        }
    }
}
