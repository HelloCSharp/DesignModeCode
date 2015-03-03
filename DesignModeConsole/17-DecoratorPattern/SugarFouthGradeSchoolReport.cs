using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.DP
{
    public class SugarFouthGradeSchoolReport:FouthGradeSchoolReport
    {
        private void ReportHighScore()
        {
            Console.WriteLine("这次考试语文最高是75，数学是78，自然是80");
        }

        private void ReportSort()
        {
            Console.WriteLine("我的排名是38名...");
        }

        public override void Report()
        {
            this.ReportHighScore();
            base.Report();
            this.ReportSort();
        }
    }
}
