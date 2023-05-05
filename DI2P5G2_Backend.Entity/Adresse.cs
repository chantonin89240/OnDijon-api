namespace DI2P5G2_Backend.Entity
{
    public class Adresse
    {
        public int Id { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public int CodePostal { get; set; }
        public string Pays { get; set; }
        public ICollection<Profil> Profils { get; set; }


        public Adresse()
        {

        }

        public Adresse(string rue, string ville, string pays, int cp, int idUser)
        {
            this.Id = idUser;
            this.Rue = rue;
            this.Ville = ville;
            this.Pays = pays;
            this.CodePostal = cp;

        }

    }

}