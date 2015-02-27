using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.LSP
{
    public class AUG:Rifle
    {
        public void ZoomOut()
        {
            Console.WriteLine("通过望远镜观察敌人...");
        }

        public override void Shoot()
        {
            Console.WriteLine("AUG射击...");
        }
    }
}
