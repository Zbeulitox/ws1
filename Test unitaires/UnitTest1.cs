using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metier;
using System;

namespace Test_unitaires
{
    [TestClass]
    public class TestMetier
    {
        [TestMethod]
        public void maison()
        {
            string input = "Maison";
            string resultat = "MAISON";
            Majusculator maison = new Majusculator();
            Assert.AreEqual (resultat, maison.Majuscule(input));

        }
        [TestMethod]
        public void maisonmaison()
        {
            Majusculator maison = new Majusculator();
            Assert.ThrowsException<Exception>(() =>
            {
                maison.Majuscule("MaisonMaison");
            });

        }
        [TestMethod]
        public void Corse123()
        {
            string input = "Corse123";
            string resultat = "CORSE123";
            Majusculator maison = new Majusculator();
            Assert.AreEqual(resultat, maison.Majuscule(input));

        }
        [TestMethod]
        public void ciel()
        {
            string input = "&%ciel";
            string resultat = "&%CIEL";
            Majusculator maison = new Majusculator();
            Assert.AreEqual(resultat, maison.Majuscule(input));

        }
        [TestMethod]
        public void port()
        {
            string input = "« !*port";
            string resultat = "« !*PORT";
            Majusculator maison = new Majusculator();
            Assert.AreEqual(resultat, maison.Majuscule(input));

        }
    }
}
