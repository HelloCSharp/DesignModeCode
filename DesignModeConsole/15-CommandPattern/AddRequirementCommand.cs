using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public class AddRequirementCommand:Command
    {
        public AddRequirementCommand() : base(new RequirementGroup()) { }
        public AddRequirementCommand(Group _receiver) : base(_receiver) { }
        public override void Execute()
        {
            base.receiver.Find();
            base.receiver.Add();
            base.receiver.Plan();
        }
    }
}
