using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza
{
    public class Commande
    {
        public Client monClient;
        public List<Pizza> mesPizzas;
        public static int numCommande;
        public bool aEmporter;
        public DateTime dateCommande;

        public Commande(Client MonClient)
        {
            monClient = MonClient;
            dateCommande = DateTime.Now;
            mesPizzas = new List<Pizza>();
            numCommande++;
        }
        public void AjouterNouvellePizza(Pizza pizza)
        {
            mesPizzas.Add(pizza);
        }
        public int GetQuantiteTotalePizzas()
        {
            return mesPizzas.Count();
        }
        public int GetNumCommande()
        {
            return numCommande;
        }
        public override string ToString()
        {
            return $"Commande #{numCommande} pour {monClient.nom} le {dateCommande:dd/MM/yyyy} à {dateCommande:t}" +
                $" pour {mesPizzas.Count()} items";
        }
    }
}
