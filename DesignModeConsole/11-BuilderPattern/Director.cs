using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.BP
{
    public class Director
    {
        private List<string> sequence = new List<string>();

        private BenzBuilder benzBuilder = new BenzBuilder();
        private BMWBuilder bmwBuilder = new BMWBuilder();

        public CarModel GetABenzModel()
        {
            this.sequence.Clear();
            this.sequence.Add("start");
            this.sequence.Add("stop");

            this.benzBuilder.SetSequence(this.sequence);
            return this.benzBuilder.GetCar();
        }

        public CarModel GetBBenzModel()
        {
            this.sequence.Clear();
            this.sequence.Add("engine boom");
            this.sequence.Add("start");
            this.sequence.Add("stop");
            this.benzBuilder.SetSequence(this.sequence);

            return this.benzBuilder.GetCar();
        }

        public CarModel GetCBMWModel()
        {
            this.sequence.Clear();
            this.sequence.Add("alarm");
            this.sequence.Add("start");
            this.sequence.Add("stop");

            this.bmwBuilder.SetSequence(this.sequence);
            return this.bmwBuilder.GetCar();
        }

        public CarModel GetDBMWModel()
        {
            this.sequence.Clear();
            this.sequence.Add("start");

            this.bmwBuilder.SetSequence(this.sequence);

            return this.bmwBuilder.GetCar();
        }
    }
}
