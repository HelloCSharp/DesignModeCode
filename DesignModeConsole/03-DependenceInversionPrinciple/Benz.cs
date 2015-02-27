using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.DIP
{
    public class Benz:ICar
    {
        public void Run()
        {
            Console.WriteLine("奔驰汽车开始运行。。。");
        }
    }
}
