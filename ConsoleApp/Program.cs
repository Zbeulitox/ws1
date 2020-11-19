using System;
using Metier;
using WindowsFormAppMétier;

namespace ConsoleAppMetier
{
    class Program : IView
    {
        Controller c;
       

        static void Main(string[] args)
        {
            new Program();
        }
        public Program()
        {
            this.c = new Controller();
            c.setIView(this);
        }

        public void displayResponse(string response)
        {
            Console.WriteLine("Le résultat est :" + response);
        }

        public void displayError(string response)
        {
            Console.WriteLine("Erreur : " + response);
        }

        public void getString()
        {
            Console.WriteLine("Entrez votre mot");
            c.checkMajusculator(Console.ReadLine());
        }
    }
}


