using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public class MaleBlackHuman:AbstractBlackHuman
    {
        public override void GetSex()
        {
            Console.WriteLine("黑人男性");
        }
    }
}
