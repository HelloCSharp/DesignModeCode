using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.ISP
{
    public class GoodBodyGirl : IGoodBodyGirl
    {
        private string Name;

        public GoodBodyGirl(string name)
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
    }
}
