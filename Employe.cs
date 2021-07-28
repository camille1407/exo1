using System;
using System.Collecteurs.Generic; 
using System.Linq;
using System.Text;

namespace essai
{

    public class  Employe
    {
        private  int Matricule;
        private  String  Nom;
        private  String  Prenom;
        private  Date  DateNaissance;
        private  Date  DateEmbauche;
        private  int Anciennete;
        private  double  Salaire;
        // constructeurs
        public Employe(int Matricule, String  Nom, String  Prenom, Date  DateNaissance, Date DateEmbauche, double Salaire)
        {
            this.Matricule = Matricule;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.DateNaissance = DateNaissance;
            this.DateEmbauche = DateEmbauche;
            this.Salaire = Salaire;
        }   
        public int getMatricule(){
            retun Matricule;
        }
        public String getNom(){
            retun Nom;
        }
        public String getPrenom(){
            retun Prenom;
        }
        public date getDateNaissance(){
            retun DateNaissance;
        }
        public date getDateEmbauche(){
            retun DateEmbauche;
        }
        public double getSalairee(){
            retun Salaire;
        }
        //methodes
        public int Age()
        {
            retun Age;
        } 
        public int Anciennete()
        {
            retun Anciennete;
        }
        public double AugmentationDuSalaire() 
        {
            if(int Anciennete < 5 || int Anciennete < 10)
            {
                Console.WriteLine("Le salaire a augmenté  est de "+2%);
                Console.WriteLine("Le salaire a augmenté  est de "+5%);
            }
            else
            {
                Console.WriteLine("Le salaire a augmenté  est de "+10%) 
            } 
        public void AfficherEmployé(int Matricule, String Nom, String  Prenom, Age, Anciennete, salaire){
            this.Matricule = Matricule;
            this.Nom_complet = Nom_complet;
            this.Age = Age;
            this.Anciennete = Anciennete;
            this.Salaire = Salaire;
        }
        public int getAge(){
            retun Age;       
        }
        public int getAnciennete(){
            retun Anciennete;
        }




    }
      
} 