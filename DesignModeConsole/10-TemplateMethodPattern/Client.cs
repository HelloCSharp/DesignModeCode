using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.TMP
{
    public class Client
    {
        public static void Test()
        {
            Console.WriteLine("------------H1型号悍马------------");
            Console.WriteLine("H1型号的悍马是否需要喇叭声响?0-不需要    1-需要");
            HummerH1Model h1 = new HummerH1Model();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.D0)
            {
                h1.SetAlarm(false);
            }
            Console.WriteLine();
            h1.Run();


            Console.WriteLine("\n------------H1型号悍马------------");
            HummerH2Model h2 = new HummerH2Model();
            h2.Run();

            Console.ReadKey();

        }
    }
}
