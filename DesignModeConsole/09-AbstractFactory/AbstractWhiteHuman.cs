using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public abstract class AbstractWhiteHuman:Human
    {
        public void GetColor()
        {
            Console.WriteLine("白色人种的皮肤是白色的！");
        }

        public void Talk()
        {
            Console.WriteLine("白色人种会说话，一般都是单字节。");
        }


        public abstract void GetSex();
    }
}
