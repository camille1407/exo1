using essai;
using System;
using System.Linq;
using System.Text;

namespace essai
{

    public class Employe
    {
        private int Matricule;
        private String Nom;
        private String Prenom;

        internal void Ajouter_Age(int v)
        {
            throw new NotImplementedException();
        }

        private DateTime DateNaissance;

        internal void Ajouter_Anciennete(int v)
        {
            throw new NotImplementedException();
        }

        internal void Ajouter_AugmentationDuSalaire()
        {
            throw new NotImplementedException();
        }

        internal void AfficherEmployé()
        {
            throw new NotImplementedException();
        }

        private DateTime DateEmbauche;
        private int Anciennete;
        private double Salaire;
        private int v1;
        private string v2;
        private int v3;
        private int v4;
        private int v5;
        private string v;
        private string v6;

        // constructeurs
        public Employe(int Matricule, String Nom, String Prenom, DateTime DateNaissance, DateTime DateEmbauche, double Salaire)
        {
            this.Matricule = Matricule;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.DateNaissance = DateNaissance;
            this.DateEmbauche = DateEmbauche;
            this.Salaire = Salaire;
        }

        public Employe(int v1, string v2, string v, int v3, int v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public Employe(int v1, string v2, int v3, int v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public Employe(int v1, string v2, string v, string v6, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v = v;
            this.v6 = v6;
            this.v5 = v5;
        }

        public int Matricule1
        {
            get => Matricule1;
        }

        public String Nom1
        {
            get => Nom1;
        }

        public String Prenom1
        {
            get => Prenom1;
        }


        public DateTime date
        {
            get => DateNaissance;
        }
        public DateTime da
        {
            get => DateEmbauche;
        }

        public double Salai
        {
            get => Salaire;
        }


        public double AugmentationDuSalaire
        {
            get => AugmentationDuSalaire;
            set
            {
                if (Anciennete < 5 && Anciennete < 10)
                {
                    Console.WriteLine("Le salaire a augmenté  est de = + 2 %");
                    Console.WriteLine("Le salaire a augmenté  est de = + 5 %");
                }
                else
                {
                    Console.WriteLine("Le salaire a augmenté  est de = + 10 %");
                }
            }
        }
    } }