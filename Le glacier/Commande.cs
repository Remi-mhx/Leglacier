namespace Le_glacier;

using System;
using System.Collections.Generic;

public class Commande
{
    private List<CoupeGlacee> _coupesGlacees = new List<CoupeGlacee>();

    public void EnregistrerCommande(CoupeGlacee coupe)
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
