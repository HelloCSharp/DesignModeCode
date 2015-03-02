using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.COR
{
    /// <summary>
    /// 责任链模式
    /// </summary>
    public class Client
    {
        public static void Test()
        {
            Random rand = new Random();
            List<IWomen> womenList = new List<IWomen>();

            for (int i = 0; i < 5; i++)
            {
                womenList.Add(new Women(rand.Next(1,4), "我要出去诳街"));
            }



            Handler father = new Father();            
            Handler husband = new Husband();
            Handler son = new Son();

            father.SetNext(husband);
            husband.SetNext(son);


            foreach (IWomen women in womenList)
            {
                father.HandleMessage(women);
                Console.WriteLine(women.GetWomenType());

            }

            Console.ReadKey();
        }
    }
}
