﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.AF
{
    public abstract class AbstractYellowHuman:Human
    {
        public void GetColor()
        {
            Console.WriteLine("黄色人种的皮肤是黄色的！");
        }

        public void Talk()
        {
            Console.WriteLine("黄色人种会说话，一般说的是双字节。");
        }


        public abstract void GetSex();
    }
}
