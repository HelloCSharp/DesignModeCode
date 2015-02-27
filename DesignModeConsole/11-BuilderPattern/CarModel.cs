using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.BP
{
    public abstract class CarModel
    {
        private List<string> Sequence = new List<string>();

        protected abstract void Start();

        protected abstract void Stop();

        protected abstract void Alarm();

        protected abstract void EngineBoom();

        public void Run()
        {
            foreach (var action in this.Sequence)
            {
                switch (action)
                {
                    case "start":
                        this.Start();
                        break;
                    case "stop":
                        this.Stop();
                        break;
                    case "alarm":
                        this.Alarm();
                        break;
                    case "engine boom":
                        this.EngineBoom();
                        break;
                    default:
                        break;
                }
            }
        }

        public void SetSequence(List<string> sequence)
        {
            this.Sequence = sequence;
        }
    }
}
