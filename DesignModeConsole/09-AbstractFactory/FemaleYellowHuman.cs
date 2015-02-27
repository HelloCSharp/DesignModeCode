using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public class FemaleYellowHuman:AbstractYellowHuman
    {
        public override void GetSex()
        {
            Console.WriteLine("黄人女性");
        }
    }
}
