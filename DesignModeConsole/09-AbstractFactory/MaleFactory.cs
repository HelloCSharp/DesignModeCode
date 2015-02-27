using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public class MaleFactory:HumanFactory
    {
        public Human CreateYellowHuman()
        {
            return new MaleYellowHuman();
        }

        public Human CreateWhiteHuman()
        {
            return new MaleWhiteHuman();
        }

        public Human CreateBlackHuman()
        {
            return new MaleBlackHuman();
        }
    }
}
