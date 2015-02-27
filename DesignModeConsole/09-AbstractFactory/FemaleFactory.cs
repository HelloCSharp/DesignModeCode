using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public class FemaleFactory:HumanFactory
    {
        public Human CreateYellowHuman()
        {
            return new FemaleYellowHuman();
        }

        public Human CreateWhiteHuman()
        {
            return new FemaleWhiteHuman();
        }

        public Human CreateBlackHuman()
        {
            return new FemaleBlackHuman();
        }
    }
}
