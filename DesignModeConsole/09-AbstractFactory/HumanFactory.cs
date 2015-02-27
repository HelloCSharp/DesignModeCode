using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public interface HumanFactory
    {
        Human CreateYellowHuman();

        Human CreateWhiteHuman();

        Human CreateBlackHuman();
    }
}
