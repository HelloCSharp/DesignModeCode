using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public abstract class Group
    {
        public abstract void Find();

        public abstract void Add();

        public abstract void Delete();

        public abstract void Change();

        public abstract void Plan();

        public void RollBack() { }
    }
}
