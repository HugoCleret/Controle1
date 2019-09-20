using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelObjet;

namespace ProjetDeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void ValiderTest()
        {
            // Le nombre de jours d'achat est < à 30 jours
            bool v1 = Condition.Valider(15);
            Assert.AreEqual(true, v1);


            // Le nombre de jours d'achat est > à 30 jours
            bool v2 = Condition.Valider(35);
            Assert.AreEqual(false, v2);
            
        }

        [TestMethod()]
        public void CalculerMontantMaxTest()
        {
            // Pour la catégorie livre
            double c1 = Condition.CalculerMontantMax("Livre");
            Assert.AreEqual(30, c1);

            // Pour la catégorie jouet
            double c2 = Condition.CalculerMontantMax("Jouet");
            Assert.AreEqual(50, c2);


            // Pour la catégorie informatique
            double c3 = Condition.CalculerMontantMax("Informatique");
            Assert.AreEqual(1000, c3);

        }

        [TestMethod()]
        public void CalculerMontantRembourseTest()
        {
            // Un livre achété 24 euros depuis 15 jours avec un état "Très abimé" en étant non membre

            // Un livre achété 24 euros depuis 15 jours avec un état "Bon" en étant membre

        }

        [TestMethod()]
        public void CalculerReductionMembreTest()
        {
            // Il est membre
            double m1 = Condition.CalculerReductionMembre(true);
            Assert.AreEqual (0, m1);



            // Il n'est pas membre
            double m2 = Condition.CalculerReductionMembre(false);
            Assert.AreEqual (0.2, m2);

        }

        [TestMethod()]
        public void CalculerReductionTest()
        {
            // Pour un état "bon"
            double r1 = Condition.CalculerReduction("bon");
            Assert.AreEqual(0.10, r1);



            // Pour un état "abimé"
            double r2 = Condition.CalculerReduction("Abimé");
            Assert.AreEqual(0.3, r2);


        }
    }
}
