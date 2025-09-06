namespace libPizza
{
    public class Client
    {
        public string adresse = "", codePostal = "", nom = "",
        prenom = "", telephone = "", ville = "";

        public Client(string Adresse, string CodePostal, string Nom, string Prenom,
        string Telephone, string Ville)
        {
            adresse = Adresse;
            codePostal = CodePostal;
            nom = Nom;
            prenom = Prenom;
            telephone = Telephone;
            ville = Ville;
        }
    }
}
