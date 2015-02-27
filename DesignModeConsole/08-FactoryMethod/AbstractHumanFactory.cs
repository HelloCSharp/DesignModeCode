using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.FM
{
    public abstract class AbstractHumanFactory
    {
        public abstract T CreateHuman<T>(T c) where T : Human;
    }
}
