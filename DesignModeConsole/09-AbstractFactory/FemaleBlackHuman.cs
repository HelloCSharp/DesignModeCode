using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public class FemaleBlackHuman:AbstractBlackHuman
    {
        public override void GetSex()
        {
            Console.WriteLine("黑人女性");
        }
    }
}
