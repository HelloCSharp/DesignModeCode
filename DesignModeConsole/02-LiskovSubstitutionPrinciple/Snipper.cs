using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.LSP
{
    public class Snipper
    {
        AUG aug;
        public void SetRifle(AUG _aug)
        {
            this.aug = _aug;
        }

        public void KillEnemy()
        {
            aug.ZoomOut();

            aug.Shoot();
        }
    }
}
