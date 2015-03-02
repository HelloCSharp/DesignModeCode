using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.COR
{
    public class Son:Handler
    {
        public Son() : base(SON_LEVEL_REQUEST) { }

        protected override void Response(IWomen women)
        {
            Console.WriteLine("-----------母亲向儿子请示-----------");
            Console.WriteLine(women.GetRequest());
            Console.WriteLine("儿子的答复是：同意");
        }
    }
}
