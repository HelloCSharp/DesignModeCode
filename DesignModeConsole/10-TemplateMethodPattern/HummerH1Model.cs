using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.TMP
{
    public class HummerH1Model:HummerModel
    {
        private bool alarmFlag = true;

        protected override void Strat()
        {
            Console.WriteLine("悍马H1发动。。。");
        }

        protected override void Stop()
        {
            Console.WriteLine("悍马H1停车。。。");
        }

        protected override void Alarm()
        {
            Console.WriteLine("悍马H1鸣笛。。。");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("悍马H1引擎声音是这样的。。。");
        }

        protected override bool IsAlarm()
        {
            return this.alarmFlag;
        }

        public void SetAlarm(bool isAlarm)
        {
            this.alarmFlag = isAlarm;
        }
    }
}
