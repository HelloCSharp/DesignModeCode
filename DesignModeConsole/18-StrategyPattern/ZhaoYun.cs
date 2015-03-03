using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.SP
{
    public class ZhaoYun
    {
        public static void Test()
        {
            Context context;

            Console.WriteLine("---刚刚到吴国的时候拆第一个---");
            context = new Context(new BackDoor());
            context.Operate();
            Console.WriteLine("\n\n");

            Console.WriteLine("--刘备乐不思蜀了，拆第二个了---");
            context = new Context(new GivenGreenLight());
            context.Operate();
            Console.WriteLine("\n\n");

            Console.WriteLine("--孙权的小兵追来了，咋办？拆第三个---");
            context = new Context(new BlockEnemy());
            context.Operate();
            Console.WriteLine("\n\n");


            Console.ReadKey();
        }
    }
}
