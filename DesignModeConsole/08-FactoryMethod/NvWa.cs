using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.FM
{
    public class NvWa
    {
        public static void Test()
        {
            AbstractHumanFactory yingYangLu = new HumanFactory();

            Console.WriteLine("--造出的第一批人是白色人种--");            
            Human witheHuman = yingYangLu.CreateHuman(new WhiteHuman());
            witheHuman.GetColor();
            witheHuman.Talk();


            Console.WriteLine("\n--造出的第二批人事黑色人种--");
            Human blackHuman = yingYangLu.CreateHuman(new BlackHuman());
            blackHuman.GetColor();
            blackHuman.Talk();

            Console.WriteLine("\n--造出的第三批人事黄色人种--");
            Human yellowHuman = yingYangLu.CreateHuman(new YellowHuman());
            yellowHuman.GetColor();
            yellowHuman.Talk();


            Console.ReadKey();

        }
    }
}
