
using System;

class Program
{
    static void Main(string[] args)
    {
        int mat;
        string nom, prenom;
        DateTime dn, de;
        double salaire;

        Console.Out.Write("Matricule: ");
        mat = int.Parse(Console.In.ReadLine());
        Console.Out.Write("Nom: ");
        nom = Console.In.ReadLine();
        Console.Out.Write("Prénom: ");
        prenom = Console.In.ReadLine();
        Console.Out.Write("Date de naissance (jj/mm/aaaa): ");
        dn = DateTime.Parse(Console.In.ReadLine());
        Console.Out.Write("Date embauche (jj/mm/aaaa): ");
        de = DateTime.Parse(Console.In.ReadLine());
        Console.Out.Write("salaire: ");
        salaire = double.Parse(Console.In.ReadLine());

        Employe e = new Employe(mat, nom, prenom, dn, de, salaire);
        e.AfficherEmploye();

        Console.Out.WriteLine("\n\nAprés application de l'augmentation de salaire");
        e.AugmentationDuSalaire();
        e.AfficherEmploye();

        Console.ReadKey();
    }
}
