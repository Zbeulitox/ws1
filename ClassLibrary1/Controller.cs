using System;
using System.Collections.Generic;
using System.Text;

namespace Metier
{
    public class Controller
    {
        IView vue;
        Majusculator m = new Majusculator();

        public Controller()
        {
      
        }

        public void setIView(IView vue)
        {
            this.vue = vue;
            this.vue.getString();

        }

        public void checkMajusculator(string text)
        {
            try
            {
                vue.displayResponse(m.Majuscule(text));
            }catch(Exception e)
            {
                vue.displayError(e.Message);
            }
        }
    }
}
