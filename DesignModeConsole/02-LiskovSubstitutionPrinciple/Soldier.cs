using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.LSP
{
    public class Soldier
    {
        private AbstractGun gun;

        public void SetGun(AbstractGun _gun)
        {
            this.gun = _gun;
        }

        public void KillEnemy()
        {
            Console.WriteLine("士兵开始杀敌人......");
            gun.Shoot();
        }
    }
}
