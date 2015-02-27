using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.OCP
{
    public class OffNovelBook:NovelBook
    {
        public OffNovelBook(string _name, int _price, string _author)
            : base(_name, _price, _author)
        { }

        public override int GetPrice()
        {
            int selfPrice = base.GetPrice();
            int offPrice = 0;
            if (selfPrice > 4000)
            {
                offPrice = selfPrice * 90 / 100;
            }
            else
            {
                offPrice = selfPrice * 80 / 100;
            }

            return offPrice;
        }
    }
}
