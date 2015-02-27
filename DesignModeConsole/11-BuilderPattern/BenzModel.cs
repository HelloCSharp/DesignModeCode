using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.BP
{
    public class BenzModel:CarModel
    {
        protected override void Start()
        {
            Console.WriteLine("奔驰车的跑起来是这个样子的。。。");
        }

        protected override void Stop()
        {
            Console.WriteLine("奔驰车应该这样停车。。。");
        }

        protected override void Alarm()
        {
            Console.WriteLine("奔驰车的喇叭声音是这个样子的。。。");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("奔驰车的引擎是这个声音的。。。");
        }
    }
}
