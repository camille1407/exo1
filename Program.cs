using System;

namespace essai
{
    class program
    {
        static void main(String[] args)
        {
            const string V = "05/11/2012";
            const string V6 = "04-08-1990";
            Employe e = new Employe(10941, "SALIM", "Omar", V6, 1000);
            e.Ajouter_Age(25);
            e.Ajouter_Anciennete(3);
            Employe m = new Employe(10941, "SALIM Omar", 25, 3, 10000);
            m.Ajouter_Age(25);
            m.Ajouter_Anciennete(3);
            m.Ajouter_AugmentationDuSalaire();
            m.AfficherEmployé();
        }
    } 
}
