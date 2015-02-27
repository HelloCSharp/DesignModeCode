using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.LSP
{
    public class MachineGun:AbstractGun
    {
        public override void Shoot()
        {
            Console.WriteLine("机枪扫射......");
        }
    }
}
