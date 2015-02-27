using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.MP
{
    public class Mediator:AbstractMediator
    {

        public override void Execute(string str, params object[] objects)
        {
            if(str.Equals("purchase.buy"))//采购电脑
            {
                this.BuyComputer((int)objects[0]);
            }
            else if(str.Equals("sale.sell"))
            {
                this.SellComputer((int)objects[0]);
            }
            else if(str.Equals("sale.offsell"))
            {
                this.OffSell();
            }
            else if(str.Equals("stock.clear"))
            {
                this.ClearStock();
            }
        }


        /// <summary>
        ///     采购电脑
        /// </summary>
        /// <param name="number"></param>
        private void BuyComputer(int number)
        {
            int saleStatus = base.sale.GetSaleStatus();

            if (saleStatus > 80) //销售情况良好
            {
                Console.WriteLine("采购IBM电脑：" + number + "台");
                base.stock.Increase(number);
            }
            else//销售情况不好
            {
                int buyNumber = number / 2;//对折采购
                Console.WriteLine("采购IBM电脑：" + buyNumber + "台");
                base.stock.Increase(buyNumber);
            }
        }


        /// <summary>
        ///     销售电脑
        /// </summary>
        /// <param name="number"></param>
        private void SellComputer(int number)
        {
            if (base.stock.GetStockNumber() < number)
            {
                base.purchase.BuyIBMComputer(number);
            }
            base.stock.Decrease(number);
        }


        /// <summary>
        ///     折价销售电脑
        /// </summary>
        private void OffSell()
        {
            Console.WriteLine("折价销售IBM电脑" + base.stock.GetStockNumber() + "台");
        }

        /// <summary>
        ///     清仓处理
        /// </summary>
        private void ClearStock()
        {
            base.sale.OffSale();
            base.purchase.RefuseBuyIBM();
        }
    }
}
