using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.LSP
{
    public class Handgun:AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("手枪射击......");
        }
    }
}
