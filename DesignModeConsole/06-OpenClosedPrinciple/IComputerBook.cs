using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.OCP
{
    public interface IComputerBook:IBook
    {
        string GetScope();
    }
}
