using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository.interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Ajoute un nouveau user.
        /// </summary>
        /// <param name="user"></param>
        void Add(User user);

        /// <summary>
        /// Supprime un user.
        /// </summary>
        /// <param name="user"></param>
        void Delete(User user);

        /// <summary>
        /// Retourne le user demandé.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User Find(int id);

        // Retourne tous les users.
        IEnumerable<User> FindAll();

        /// <summary>
        /// Met à jour un artiste.
        /// </summary>
        /// <param name="artiste"></param>
        void Update(User user);

    }
}
