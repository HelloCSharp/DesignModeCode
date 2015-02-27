using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.MP
{
    public class Purchase:AbstractColleague
    {
        public Purchase(AbstractMediator _mediator):base(_mediator)
        {
            
        }

        public void BuyIBMComputer(int number)
        {
            base.mediator.Execute("purchase.buy", number);
        }

        public void RefuseBuyIBM()
        {
            Console.WriteLine("不再采购IBM电脑");
        }
    }
}
