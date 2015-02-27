using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.MP
{
    public class Client
    {
        public static void Test()
        {
            AbstractMediator mediator = new Mediator();

            Console.WriteLine("-----------------采购人员采购电脑-----------------");
            Purchase purchase = new Purchase(mediator);
            purchase.BuyIBMComputer(100);

            Console.WriteLine("/n-----------------销售人员销售电脑-----------------");
            Sale sale = new Sale(mediator);
            sale.SellIBMComputer(1);

            Console.WriteLine("/n-----------------库房管理人员清库处理-----------------");
            Stock stock = new Stock(mediator);
            stock.ClearStock();

            Console.ReadKey();

        }
    }
}
