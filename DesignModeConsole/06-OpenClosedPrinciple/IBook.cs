using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.OCP
{
    public interface IBook
    {
        string GetName();

        int GetPrice();

        string GetAuthor();
    }
}
