using System;
using System.Collections.Generic;

// Classe représentant un produit
public class Produit
{
    public string Nom { get; set; }
    public decimal Prix { get; set; }
    public int QuantiteEnStock { get; set; }

    public Produit(string nom, decimal prix, int quantiteEnStock)
    {
        Nom = nom;
        Prix = prix;
        QuantiteEnStock = quantiteEnStock;
    }
}

// Classe représentant une commande
public class Commande
{
    public List<Produit> Produits { get; set; }

    public Commande()
    {
        Produits = new List<Produit>();
    }

    public void AjouterProduit(Produit produit)
    {
        Produits.Add(produit);
    }

    public decimal CalculerMontantTotal()
    {
        decimal montantTotal = 0;

        foreach (var produit in Produits)
        {
            montantTotal += produit.Prix;
        }

        return montantTotal;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Commande commande = new Commande();

        // Ajouter des produits à la commande
        Produit produit1 = new Produit("Produit1", 10.50m, 10);
        Produit produit2 = new Produit("Produit2", 16.75m, 15);
        commande.AjouterProduit(produit1);
        commande.AjouterProduit(produit2);

        // Afficher le montant total de la commande
        decimal montantTotal = commande.CalculerMontantTotal();
        Console.WriteLine("Montant total de la commande : " + montantTotal);
    }
}
