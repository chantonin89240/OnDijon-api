namespace DI2P5G2_Backend.Entity
{
    public class User 
    {
        public int? Id { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public DateTime? DateDeNaissance { get; set; }
        public string? Mail { get; set; }

        public User()
        {

        }

        public User(int idProfil)
        {
            Id = idProfil;
        }

        public User(int idUser, string nom, string prenom, DateTime dateDeNaissance, string email)
        {
            this.Id = idUser;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateDeNaissance = dateDeNaissance;
            this.Mail = email;

        }

    }

}