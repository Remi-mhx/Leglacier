namespace Le_glacier;

using System;

class Program
{
    static void Main()
    {
        Commande commande = new Commande();
        string reponse;

        do
        {
            Console.WriteLine("Quelle coupe glacée voulez-vous ?");
            Console.WriteLine("1. Triple chocolat");
            Console.WriteLine("2. Fruits rouges");
            Console.Write("Votre choix (1 ou 2) : ");
            string choix = Console.ReadLine();

            CoupeGlacee coupe = null;

            if (choix == "1")
                coupe = new TripleChocolat();
            else if (choix == "2")
                coupe = new FruitsRouges();

            if (coupe != null)
            {
                string reponseSupplement;
                do
                {
                    Console.WriteLine("Voulez-vous un supplément (o/n) ?");
                    reponseSupplement = Console.ReadLine().ToLower();
                    if (reponseSupplement == "o")
                    {
                        Console.WriteLine("Quel supplément voulez-vous rajouter ?");
                        Console.WriteLine("0. Aucun");
                        Console.WriteLine("1. De la chantilly");
                        Console.WriteLine("2. un coulis de fraises fraîches");
                        Console.WriteLine("3. un nappage chocolat chaud");
                
                        string choixSupplement = Console.ReadLine();
                        Console.WriteLine("Votre choix : " + choixSupplement);

                        if (choixSupplement == "1")
                            coupe = new ChantillyDecorator(coupe);
                        else if (choixSupplement == "2")
                            coupe = new CoulisFraiseDecorator(coupe);
                        else if (choixSupplement == "3")
                            coupe = new NappageChocolatDecorator(coupe);
                    }

                }while (reponseSupplement != "n");
                commande.EnregistrerCommande(coupe);
            }

            Console.Write("Voulez-vous acheter une autre coupe glacée (o/n) : ");
            reponse = Console.ReadLine().ToLower();
        }
        while (reponse == "o");

        Console.WriteLine("\n");
        commande.AfficherCommande();
    }
}