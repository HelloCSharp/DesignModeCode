using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.DIP
{
    public class DIPClient
    {
        public static void Test()
        {
            IDriver iDriver = new DriverCar();

            ICar iCar = new BMW();

            iDriver.Driver(iCar);

            Console.ReadKey();
        }
    }
}
