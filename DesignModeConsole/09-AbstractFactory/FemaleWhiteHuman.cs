using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public class FemaleWhiteHuman:AbstractWhiteHuman
    {
        public override void GetSex()
        {
            Console.WriteLine("白人女性");
        }
    }
}
