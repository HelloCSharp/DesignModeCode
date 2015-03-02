using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.COR
{
    public class Women:IWomen
    {
        /// <summary>
        ///     1:未出嫁   2：出嫁    3：夫死
        /// </summary>
        private int type = 0;

        private string request = "";

        public Women(int _type,string _request)
        {
            this.type = _type;

            switch(this.type)
            {
                case 1:
                    this.request = "女儿的请示是：" + _request;
                    break;
                case 2:
                    this.request = "妻子的请示是：" + _request;
                    break;
                case 3:
                    this.request = "母亲的请示是：" + _request;
                    break;
            }

            this.request = _request;
        }

        public int GetWomenType()
        {
            return this.type;
        }

        public string GetRequest()
        {
            return request;
        }
    }
}
