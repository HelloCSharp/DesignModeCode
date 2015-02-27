using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.DIP
{
    public class BMW:ICar
    {
        public void Run()
        {
            Console.WriteLine("宝马汽车开始运行。。。");
        }
    }
}
