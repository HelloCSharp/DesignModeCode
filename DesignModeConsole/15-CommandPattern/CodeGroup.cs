using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public class CodeGroup:Group
    {
        public override void Find()
        {
            Console.WriteLine("找到代码组。。。");
        }

        public override void Add()
        {
            Console.WriteLine("客户要求增加一个功能。。。");
        }

        public override void Delete()
        {
            Console.WriteLine("客户要求删除一个功能。。。");
        }

        public override void Change()
        {
            Console.WriteLine("客户要求修改一个功能。。。");
        }

        public override void Plan()
        {
            Console.WriteLine("客户要求代码变更计划。。。");
        }
    }
}
