using DI2P5G2_Backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2P5G2_Backend.Repository.interfaces
{
    public interface IProfilRepository
    {
        /// <summary>
        /// Ajoute un nouveau user.
        /// </summary>
        /// <param name="user"></param>
        void Add(Profil user);

        /// <summary>
        /// Supprime un user.
        /// </summary>
        /// <param name="user"></param>
        void Delete(Profil user);

        /// <summary>
        /// Retourne le user demandé.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Profil Find(int id);

        // Retourne tous les users.
        IEnumerable<Profil> FindAll();

        /// <summary>
        /// Met à jour un artiste.
        /// </summary>
        /// <param name="artiste"></param>
        void Update(Profil user);

    }
}
