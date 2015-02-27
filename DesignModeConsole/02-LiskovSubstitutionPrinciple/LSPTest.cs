using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.LSP
{
    public class LSPTest
    {
        public static void Test()
        {
            //Soldier sanMao = new Soldier();
            //sanMao.SetGun(new Rifle());
            //sanMao.KillEnemy();

            Snipper snipper = new Snipper();
            snipper.SetRifle(new AUG());
            snipper.KillEnemy();

            Console.ReadKey();
        }
    }
}
