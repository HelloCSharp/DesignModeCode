﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.LSP
{
    public class Rifle:AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("步枪射击......");
        }
    }
}
