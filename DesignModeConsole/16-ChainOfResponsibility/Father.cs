using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.COR
{
    public class Father:Handler
    {
        public Father():base(FATHER_LEVEL_REQUEST)
        {

        }

        protected override void Response(IWomen women)
        {
            Console.WriteLine("-----------女儿向父亲请示-----------");
            Console.WriteLine(women.GetRequest());
            Console.WriteLine("父亲的答复是：同意");
        }
    }
}
