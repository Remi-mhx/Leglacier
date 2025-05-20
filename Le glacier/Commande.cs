namespace Le_glacier;

using System;
using System.Collections.Generic;

public class Commande
{
    private List<ICoupeGlacee> _coupesGlacees = new List<ICoupeGlacee>();

    public void EnregistrerCommande(ICoupeGlacee coupe)
    {
        _coupesGlacees.Add(coupe);
    }

    public void AfficherCommande()
    {
        double total = 0;
        int numero = 1;

        foreach (var coupe in _coupesGlacees)
        {
            Console.WriteLine("******************************");
            Console.WriteLine($"Coupe numéro {numero}");
            Console.WriteLine(coupe.Description());
            Console.WriteLine($"{coupe.Prix()} Euros\n");
            total += coupe.Prix();
            numero++;
        }

        Console.WriteLine($"POUR UN MONTANT TOTAL DE : {total} Euros");
    }
}
