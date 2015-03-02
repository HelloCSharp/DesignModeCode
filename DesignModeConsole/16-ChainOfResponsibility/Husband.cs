using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.COR
{
    public class Husband:Handler
    {
        public Husband() : base(HUSBAND_LEVEL_REQUEST) { }

        protected override void Response(IWomen women)
        {
            Console.WriteLine("-----------妻子向丈夫请示-----------");
            Console.WriteLine(women.GetRequest());
            Console.WriteLine("丈夫的答复是：同意");
        }
    }
}
