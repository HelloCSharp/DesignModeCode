using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.DIP
{
    public class DriverCar:IDriver
    {
        public void Driver(ICar car)
        {
            car.Run();
        }

    }
}
