using System;

namespace ModelObjet
{
    public class Condition
    {
        // Permet de savoir si on a le droit d'être remboursé
        // On l'est à condition que le nombre de jours ne dépasse pas 30 !
        public static bool Valider(int unNbDeJours)
        {
            if (unNbDeJours > 30)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Permet de renvoyer le montant MAX remboursé en fonction de la catégorie
        public static int CalculerMontantMax(string uneCategorie)
        {
            int MontantMax = 0;
            if (uneCategorie == "Livre")
            {
                MontantMax = 30;
               
            }
            if (uneCategorie == "Jouet")
                {
                MontantMax = 50;
                
                }
            if (uneCategorie == "Informatique")
            {
                MontantMax = 1000;
              
            }
            return MontantMax;


        }
        
        // Permet de retourner le total remboursé en fonction de tous les critères
        public static double CalculerMontantRembourse(int unNbDeJours, string uneCategorie, bool estMembre, string unEtat, int unPrix)
        {
            if (Valider(unNbDeJours) == true)
            {
                if (CalculerMontantMax(uneCategorie) == 30)
                {
                    if (estMembre == true)
                    {
                        if (unEtat == "Abime" || unEtat == "Tres abime")
                        {
                            return unPrix * 0.70;

                        }


                    }
                    else
                    {
                        return unPrix * 0.80;
                    }

                }
            }

        }
        // Permet de renvoyer la réduction si on est membre ou pas
        public static double CalculerReductionMembre(bool estMembre)
        {
            
            double rf = 0;
            if (estMembre == true)
            {

                rf = 0;
                    return rf;
            }
            else
            {
                rf = 0.2;
                return rf; 
            }
            
        }
        // Permet de renvoyer la réduction en fonction de l'état de l'achat
        public static double CalculerReduction(string unEtat)
        {
            double p = 0;
            double r = 0;
            if (unEtat=="Abimé" || unEtat == "TrésAbimé")
            {
                 r = 0.3;
                return r;
            }
            else
            {
                r = 0.10;
                return r;
            }

            
        }
    }
}
