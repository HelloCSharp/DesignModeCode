using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.CP
{
    public class RequirementGroup:Group
    {
        public override void Find()
        {
            Console.WriteLine("找到需求组。。。");
        }

        public override void Add()
        {
            Console.WriteLine("客户要求增加一项需求。。。");
        }

        public override void Delete()
        {
            Console.WriteLine("客户要求删除一项需求。。。");
        }

        public override void Change()
        {
            Console.WriteLine("客户要求修改一项需求。。。");
        }

        public override void Plan()
        {
            Console.WriteLine("客户要求需求变更计划。。。");
        }
    }
}
