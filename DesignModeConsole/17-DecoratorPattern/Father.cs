using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.DP
{
    public class Father
    {
        public static void Test()
        {
            SchoolReport sr = new FouthGradeSchoolReport();

            sr = new HighScoreDecorator(sr);
            sr = new SortDecorator(sr);

            sr.Report();
            sr.Sign("老三");

            Console.ReadKey();
        }
    }
}
