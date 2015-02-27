using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.BP
{
    public abstract class CarBuilder
    {
        public abstract void SetSequence(List<string> sequence);

        public abstract CarModel GetCar();
    }
}
