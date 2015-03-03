using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.SP
{
    public class GivenGreenLight:IStrategy
    {

        public void Operate()
        {
            Console.WriteLine("求吴国太开绿灯，放行");
        }
    }
}
