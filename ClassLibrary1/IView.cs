using System;
using System.Collections.Generic;
using System.Text;

namespace Metier
{
    public interface IView
    {
        void displayResponse(string response);

        void displayError(string response);

        void getString();
    }
}
