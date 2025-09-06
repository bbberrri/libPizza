using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPizza
{
    public class Pizza
    {
        public string nom = "";

        public Pizza(string Nom) => nom = Nom;
        public string GetNomPizza()
        {
            return nom;
        }
    }
}
