using System;

namespace essai
{
    class program
    {
       static void main(String[] args)
       {
           Employe e = new Employe(10941,"SALIM","Omar","04/08/1990","05/11/2012",1000);
           e.Ajouter_Age(25);
           e.Ajouter_Anciennete(3);
           e.Ajouter_AugmentationDuSalaire();
           Date d = new Date();
           Employe m = new Employe(10941,"SALIM Omar", 25,3,10000);
           m.Ajouter_Age(25);
           m.Ajouter_Anciennete(3);
           m.Ajouter_AugmentationDuSalaire();
    }
}
