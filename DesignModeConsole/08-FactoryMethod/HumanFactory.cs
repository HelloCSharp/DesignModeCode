using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace DesignModeConsole.FM
{
    public class HumanFactory:AbstractHumanFactory
    {
        public override T CreateHuman<T>(T c)
        {
            Human human = null;
            try
            {
                //human = (T)Assembly.Load("DesignModeConsole").CreateInstance("DesignModeConsole.FM."+c.ToString());
                human = c;
            }
            catch (Exception ex)
            {
                Console.WriteLine("人种生成错误！");
                
            }

            return (T)human;
        }
    }
}
