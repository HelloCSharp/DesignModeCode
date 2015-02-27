using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.FM
{
    public class BlackHuman:Human
    {
        public void GetColor()
        {
            Console.WriteLine("黑色人种的皮肤是黑色的！");
        }

        public void Talk()
        {
            Console.WriteLine("黑人会说话，一般人听不懂。");
        }
    }
}
