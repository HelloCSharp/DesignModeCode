using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public class CancelDeletePageCommand:Command
    {
        public CancelDeletePageCommand(Group _receiver) : base(_receiver) { }

        public override void Execute()
        {
            base.receiver.RollBack();
        }
    }
}
