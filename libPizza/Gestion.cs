using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace libPizza
{
    public class Gestion
    {
        public List<Client> mesClients;
        public List<Commande> mesCommandes;
        public List<Pizza> mesPizzas;
        public Gestion()
        {
            mesClients = new List<Client>();
            mesCommandes = new List<Commande>();
            mesPizzas = new List<Pizza>();
        }
        public int AjouterCommande(Client client)
        {
            Commande co = new Commande(client);
            mesCommandes.Add(co);
            return co.GetNumCommande();
        }
        public void AjouterNouveauClient(string adresse, string codePostal, string nom, string prenom,
                                         string telephone, string ville)
        {
            Client cl = new Client(adresse, codePostal, nom, prenom, telephone, ville);
            mesClients.Add(cl);
        }
        public void AjouterNouvellePizza(string nom, int prix)
        {
            Pizza p = new Pizza(nom, prix);
            mesPizzas.Add(p);
        }
        public void AjouterPizza(Pizza pizza, int numCommande)
        {
            foreach (Commande i in mesCommandes)
            {
                if (i.GetNumCommande() == numCommande)
                {
                    i.AjouterNouvellePizza(pizza);
                }
            }
        }
        public List<Client> GetListClient()
        {
            return mesClients;
        }
        public List<Pizza> GetListPizza()
        {
            return mesPizzas;
        }
        public Client GetClient(string nomClient)
        {
            foreach (Client i in mesClients)
            {
                if (i.nom == nomClient)
                {
                    return i;
                }
            }
            return mesClients[0]; //temporaire
        }
        public Pizza GetPizza(string pizza)
        {
            foreach (Pizza i in mesPizzas)
            {
                if (i.nom == pizza)
                {
                    return i;
                }
            }
            return mesPizzas[0]; //temporaire
        }
        public Commande GetCommande(int numCommande)
        {
            foreach (Commande i in mesCommandes)
            {
                if (i.GetNumCommande() == numCommande)
                {
                    return i;
                }
            }
            return mesCommandes[0]; //temporaire
        }
        public string AfficherCommande(int numCommande)
        {
            return GetCommande(numCommande).ToString();
        }
    }
}
