using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.interfaces;

namespace DI2P5G2_Backend.Repository
{
    public class DbUserRepository : IUserRepository
    {
        private DI2P5G2_BackendDbContext context;
        public DbUserRepository(DI2P5G2_BackendDbContext dbContext)
        {
            context = dbContext;
        }

        public void Add(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
        }

        public void Delete(User user)
        {
            context.User.Remove(user);
            context.SaveChanges();
        }

        public User Find(int id)
        {
            var user = context.User.FirstOrDefault(user => user.Id == id);

            return user;
        }

        public IEnumerable<User> FindAll()
        {
            var users = context.User.ToList();

            return users;
        }

        public void Update(User user)
        {
            context.Update(user);
            context.SaveChanges();
        }

    }
}