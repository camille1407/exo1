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
        private DateTime DateNaissance;
        private DateTime DateEmbauche;
        private double Salaire;
       

        // constructeurs
        public Employe(int LeMatricule, String Nom, String Prenom, DateTime DateNaissance, DateTime DateEmbauche, double Salaire)
        {
            this.Matricule = LeMatricule;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.DateNaissance = DateNaissance;
            this.DateEmbauche = DateEmbauche;
            this.Salaire = Salaire;
        }


        
        public double AugmentationDuSalaire()
        {
                /*if (Anciennete < 5 && Anciennete < 10)
                {
                    Console.WriteLine("Le salaire a augmenté  est de = + 2 %");
                    Console.WriteLine("Le salaire a augmenté  est de = + 5 %");
                }
                else
                {
                    Console.WriteLine("Le salaire a augmenté  est de = + 10 %");
                }*/
            
            return 0;
        }
    } }