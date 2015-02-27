using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public class NvWa
    {
        public static void Test()
        {
            HumanFactory femaleFactory = new FemaleFactory();
            HumanFactory maleFactory = new MaleFactory();

            Console.WriteLine("---生产一个黑人女性---");
            var femaleBlackHuman = femaleFactory.CreateBlackHuman();
            femaleBlackHuman.GetColor();
            femaleBlackHuman.GetSex();
            femaleBlackHuman.Talk();

            Console.WriteLine("\n---生产一个黑人男性---");
            var maleBlackHuman = maleFactory.CreateBlackHuman();
            maleBlackHuman.GetColor();
            maleBlackHuman.GetSex();
            maleBlackHuman.Talk();

            Console.ReadKey();
        }
    }
}
