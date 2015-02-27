using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.MP
{
    public class Sale:AbstractColleague
    {
        public Sale(AbstractMediator _mediator) : base(_mediator) { }

        /// <summary>
        ///     销售IBM电脑
        /// </summary>
        /// <param name="number"></param>
        public void SellIBMComputer(int number)
        {
            
            base.mediator.Execute("sale.sell", number);
            Console.WriteLine("销售IBM电脑" + number + "台");

            
        }

        /// <summary>
        ///     反馈销售情况，0-100之间变化，0代表根本就没人卖，100代表非常畅销，出一个卖一个
        /// </summary>
        /// <returns></returns>
        public int GetSaleStatus()
        {
            Random rand = new Random();
            
            int saleStatus = rand.Next(100);
            Console.WriteLine("IBM电脑的销售情况为：" + saleStatus);

            return saleStatus;
        }

        /// <summary>
        ///     折价处理
        /// </summary>
        public void OffSale()
        {
            base.mediator.Execute("sale.offsell");
        }
    }
}
