using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.ISP
{
    public class ISPTest
    {
        public static void Test()
        {
            #region ISP TEST
            PettyGirl yanYan = new PettyGirl("嫣嫣");

            AbstractSearcher searcher = new Searcher(yanYan);

            searcher.Show();
            Console.WriteLine();

            IGoodBodyGirl goodBodyGirl = new GoodBodyGirl("美美");
            AbstractSearcher searcherMM = new Searcher(goodBodyGirl);
            searcherMM.ShowGoodBody();

            Console.ReadKey();

            #endregion
        }
    }
}
