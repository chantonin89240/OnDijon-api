namespace DI2P5G2_Backend.Entity
{
    public class User 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public string Adresse { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Email { get; set; }

        public User()
        {

        }

        public User(int idProfil)
        {
            Id = idProfil;
        }

        public User(int idUser, string nom,DateTime dateDeNaissance, string email, string adresse, int age)
        {
            this.Id = idUser;
            this.Nom = nom;
            this.DateDeNaissance = dateDeNaissance;
            this.Email = email;
            this.Adresse = adresse;
            this.Age = age;

        }

    }

}