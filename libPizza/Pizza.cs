using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza
{
    public class Pizza
    {
        public string nom;
        public double prix;

        public Pizza(string Nom, double Prix)
        {
            nom = Nom;
            prix = Prix;
        }
        public string GetNomPizza()
        {
            return nom;
        }
    }
}
