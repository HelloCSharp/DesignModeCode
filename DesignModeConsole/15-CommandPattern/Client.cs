using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public class Client
    {
        public static void Test()
        {
            Invoker xiaoSan = new Invoker();

            Console.WriteLine("-----------------------客户要求增加一项需求-----------------------");

            //Command command = new AddRequirementCommand();
            Command command = new DeletePageCommand();
            xiaoSan.SetCommand(command);
            xiaoSan.Action();

            Console.ReadKey();
        }
    }
}
