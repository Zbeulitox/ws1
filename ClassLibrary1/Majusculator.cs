using System;

namespace Metier
{
    public class Majusculator
    {
        public string Majuscule(string mot)
        {
            if  (mot.Length > 8 || mot.Length < 1)
            {
                throw new Exception("Le nombre de caractère est incorrect");
            }
            else
            {
                return mot.ToUpper();
                
            }
        }

       
    }
}
