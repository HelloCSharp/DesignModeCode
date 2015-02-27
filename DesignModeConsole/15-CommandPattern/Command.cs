using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public abstract class Command
    {
        protected Group receiver;

        public Command(Group _receiver)
        {
            this.receiver = _receiver;

        }


        public abstract void Execute();
    }
}
