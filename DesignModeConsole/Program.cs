using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignModeConsole.LSP;

using DesignModeConsole.ISP;

using DesignModeConsole.FM;

namespace DesignModeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignModeConsole.DP.Father.Test();
            return;
            DesignModeConsole.COR.Client.Test();
            return;
            DesignModeConsole.CP.Client.Test();
            return;
            DesignModeConsole.MP.Client.Test();
            return;
            DesignModeConsole.PP.Client.Test();
            return;
            DesignModeConsole.BP.Client.Test();
            return;
            DesignModeConsole.TMP.Client.Test();
            return;
            NvWa.Test();
            //DesignModeConsole.OCP.BookStore.Test();
            return;
            //DesignModeConsole.DIP.DIPClient.Test();

            //return;
            //LSPTest.Test();
            //return;


            ISPTest.Test();
        }
    }
}
