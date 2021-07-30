using System;

class Employe
{
    //Définir une classe Employé caractérisée par les attributs : Matricule, Nom, Prénom, DateNaissance, DateEmbauche, Salaire.
    private int matricule;
    private string nom;
    private string prenom;
    private DateTime datenaissance;
    private DateTime dateembauche;
    private double salaire;

    //Définir à l’aide des propriétés les méthodes d’accès aux différents attributs de la classe.
    public int Matricule
    {
        get { return matricule; }
        set { matricule = value; }
    }

    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }

    public DateTime Datenaissance
    {
        get { return datenaissance; }
        set { datenaissance = value; }
    }

    public DateTime Dateembauche
    {
        get { return dateembauche; }
        set { dateembauche = value; }
    }

    public double Salaire
    {
        get { return salaire; }
        set { salaire = value; }
    }
    //Définir à l’aide des propriétés les méthodes d’accès aux différents attributs de la classe.

    //Définir un constructeur permettant d’initialiser les attributs de la méthode par des valeurs saisies par l’utilisateur.
    public Employe(int m, string n, string p, DateTime dn, DateTime de, double s)
    {
        matricule = m;
        nom = n;
        prenom = p;
        datenaissance = dn;
        dateembauche = de;
        salaire = s;
    }

   // Ajouter à la classe la méthode Age() qui retourne l’âge de l’employé.
    public int Age()
    {
        int age;
        age = DateTime.Now.Year - datenaissance.Year;
        if (datenaissance.AddYears(age) > DateTime.Now.Date)
            age--;
        return age;
    }

    //Ajouter à la classe la méthode Anciennete( ) qui retourne le nombre d’années d’ancienneté de l’employé.
    public int Anciennete()
    {
        int Anc;
        Anc = DateTime.Now.Year - dateembauche.Year;
        if (dateembauche.AddYears(Anc) > DateTime.Now.Date)
            Anc--;
        return Anc;

    }

    //Ajouter à la classe la méthode AugmentationDuSalaire( ) qui augmente le salaire de l’employé en prenant en considération l’ancienneté.
    public void AugmentationDuSalaire()
    {
        if (Anciennete() < 5)
            salaire += salaire * 0.02;
        else if (Anciennete() < 10)
            salaire += salaire * 0.05;
        else
            salaire += salaire * 0.1;
    }

    //Ajouter la méthode AfficherEmployé() qui affiche les informations de l’employé (pour le reste de la question refere toi au mail que je t'ai envoye
    public void AfficherEmploye()
    {
        Console.Out.WriteLine("\n\nMatricule : " + matricule);
        Console.Out.WriteLine("Nom Complet : " + nom.ToUpper() + " " + prenom.Substring(0, 1).ToUpper() + prenom.Substring(1).ToLower());
        Console.Out.WriteLine("Age : " + Age());
        Console.Out.WriteLine("Ancienneté : " + Anciennete());
        Console.Out.WriteLine("Salaire : " + salaire);
    }
}
