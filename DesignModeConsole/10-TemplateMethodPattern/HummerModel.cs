using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.TMP
{
    public abstract class HummerModel
    {
        protected abstract void Strat();

        protected abstract void Stop();

        protected abstract void Alarm();

        protected abstract void EngineBoom();

        public void Run()
        {
            this.Strat();
            this.EngineBoom();

            if(this.IsAlarm())
            {
                this.Alarm();
            }

            this.Stop();

        }

        protected virtual bool IsAlarm()
        {
            return true;
        }


    }
}
