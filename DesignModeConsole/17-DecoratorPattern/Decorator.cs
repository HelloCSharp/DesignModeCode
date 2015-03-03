using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.DP
{
    public abstract class Decorator:SchoolReport
    {
        private SchoolReport schoolReport;

        public Decorator(SchoolReport sr)
        {
            this.schoolReport = sr;
        }

        public override void Report()
        {
            this.schoolReport.Report();
        }


        public override void Sign(string name)
        {
            this.schoolReport.Sign(name);
        }
    }
}
