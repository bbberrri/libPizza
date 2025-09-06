using libPizza;
internal class Program
{
    private static void Main(string[] args)
    {
        Client c1 = new Client("5 square de Blois", "95380", "Berri", "Bilal", "+33782935428", "Louvres");
        Pizza p1 = new Pizza("Reine");
        Pizza p2 = new Pizza("Calzone");
        Console.WriteLine(c1.nom);
        Console.WriteLine(p1.GetNomPizza());
        Console.WriteLine(p2.GetNomPizza());
        Commande co1 = new Commande(c1);
        co1.AjouterNouvellePizza(p1);
        co1.AjouterNouvellePizza(p2);
        Console.WriteLine(co1.ToString());
    }
}