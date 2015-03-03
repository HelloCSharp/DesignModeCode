using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.DP
{
    public class SortDecorator:Decorator
    {
        public SortDecorator(SchoolReport sr) : base(sr) { }

        private void ReportSort()
        {
            Console.WriteLine("我的排名是38名...");
        }

        public override void Report()
        {
            base.Report();
            this.ReportSort();
        }
    }
}
