using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public class PageGroup:Group
    {

        public override void Find()
        {
            Console.WriteLine("找到美工组。。。");
        }

        public override void Add()
        {
            Console.WriteLine("客户要求增加一个页面。。。");
        }

        public override void Delete()
        {
            Console.WriteLine("客户要求删除一个页面。。。");
        }

        public override void Change()
        {
            Console.WriteLine("客户要求修改一个页面。。。");
        }

        public override void Plan()
        {
            Console.WriteLine("客户要求页面变更计划。。。");
        }
    }
}
