using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public class MaleWhiteHuman:AbstractWhiteHuman
    {
        public override void GetSex()
        {
            Console.WriteLine("白人男性");
        }
    }
}
