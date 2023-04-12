using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;

namespace DI2P5G2_Backend.Repository
{
    public class DbProfilRepository : IProfilRepository
    {
        private DI2P5G2_BackendDbContext context;
        public DbProfilRepository(DI2P5G2_BackendDbContext dbContext)
        {
            context = dbContext;
        }

        public void Add(Profil user)
        {
            context.User.Add(user);
            context.SaveChanges();
        }

        public void Delete(Profil user)
        {
            context.User.Remove(user);
            context.SaveChanges();
        }

        public Profil Find(int id)
        {
            var user = context.User.FirstOrDefault(user => user.Id == id);

            return user;
        }

        public IEnumerable<Profil> FindAll()
        {
            var users = context.User.ToList();

            return users;
        }

        public void Update(Profil user)
        {
            context.Update(user);
            context.SaveChanges();
        }

    }
}