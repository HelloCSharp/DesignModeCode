using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.MP
{
    /// <summary>
    ///     库存
    /// </summary>
    public class Stock:AbstractColleague
    {
        public Stock(AbstractMediator _mediator) : base(_mediator) { }

        private static int COMPUTER_NUMBER = 100;

        /// <summary>
        ///     库存增加
        /// </summary>
        /// <param name="number"></param>
        public void Increase(int number)
        {
            COMPUTER_NUMBER = COMPUTER_NUMBER + number;
            Console.WriteLine("库存数量为：" + COMPUTER_NUMBER);
        }

        /// <summary>
        ///     库存降低
        /// </summary>
        /// <param name="number"></param>
        public void Decrease(int number)
        {
            COMPUTER_NUMBER = COMPUTER_NUMBER - number;
            Console.WriteLine("库存数量为：" + COMPUTER_NUMBER);
        }

        /// <summary>
        ///     获取库存数量
        /// </summary>
        /// <returns></returns>
        public int GetStockNumber()
        {
            return COMPUTER_NUMBER;
        }

        /// <summary>
        ///     库存压力大了，就要通知采购人员不要采购，销售人员要尽快销售
        /// </summary>
        public void ClearStock()
        {
            Console.WriteLine("清理存货数量为：" + COMPUTER_NUMBER);
            base.mediator.Execute("stock.clear");
            
        }
    }
}
