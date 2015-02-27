using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public class DeletePageCommand:Command
    {
        public DeletePageCommand() : base(new PageGroup()) { }
        public DeletePageCommand(Group _receiver) : base(_receiver) { }
        public override void Execute()
        {
            base.receiver.Find();
            base.receiver.Delete();
            base.receiver.Plan();
        }
    }
}
