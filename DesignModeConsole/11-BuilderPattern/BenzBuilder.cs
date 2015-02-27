using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.BP
{
    public class BenzBuilder:CarBuilder
    {
        private BenzModel benz = new BenzModel();
        public override void SetSequence(List<string> sequence)
        {
            this.benz.SetSequence(sequence);
        }

        public override CarModel GetCar()
        {
            return this.benz;
        }
    }
}
