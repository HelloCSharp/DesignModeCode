using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.ISP
{
    public class PettyGirl:IGoodBodyGirl,IGreatTemperamentGirl
    {
        private string Name;

        public PettyGirl(string name)
        {
            this.Name = name;
        }

        public void GoodLooking()
        {
            Console.WriteLine(this.Name + "---脸蛋很漂亮！");
        }

        public void NiceFigure()
        {
            Console.WriteLine(this.Name + "---气质非常好！");
        }

        public void GreatTemperament()
        {
            Console.WriteLine(this.Name + "---身材非常棒！");
        }
    }
}
