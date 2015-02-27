using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.BP
{
    public class BMWBuilder:CarBuilder
    {
        private BMWModel bmw = new BMWModel();
        public override void SetSequence(List<string> sequence)
        {
            this.bmw.SetSequence(sequence);
        }

        public override CarModel GetCar()
        {
            return this.bmw;
        }
    }
}
