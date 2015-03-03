using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.SP
{
    public class BlockEnemy:IStrategy
    {
        public void Operate()
        {
            Console.WriteLine("孙夫人断后，挡住追兵");
        }
    }
}
