using libPizza;
internal class Program
{
    private static void Main(string[] args)
    {
        Client cl1 = new Client("5 square de Blois", "95380", "Berri", "Bilal", "+33782935428", "Louvres");
        Client cl2 = new Client("6 square de Blois", "95380", "Berri2", "Bilal2", "+33756965756", "Louvres");

        Pizza p1 = new Pizza("Reine", 5.8);
        Pizza p2 = new Pizza("Calzone", 6);
        Pizza p3 = new Pizza("Margarita", 4.6);

        Console.WriteLine(cl1.nom);
        Console.WriteLine(p1.GetNomPizza());
        Console.WriteLine(p2.GetNomPizza());
        
        Commande co1 = new Commande(cl2);

        co1.AjouterNouvellePizza(p1);
        co1.AjouterNouvellePizza(p2);
        
        Console.WriteLine(co1.ToString());
        
        Gestion g = new Gestion();
        
        Console.WriteLine(g.AjouterCommande(cl2));
        
        g.AjouterNouveauClient("3 rue de Paris", "95380", "Pozqrejz", "Oifoiezr", "+33734657656", "Louvres");
        g.AjouterPizza(p3, 2);
        g.AjouterNouvellePizza("AAA", 666);
        
        Console.WriteLine(co1.ToString());
        Console.WriteLine(g.AfficherCommande(2));
    }
}