using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.SP
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Operate()
        {
            this.strategy.Operate();
        }
    }
}
