using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.ISP
{
    public class Searcher:AbstractSearcher
    {
        public Searcher(PettyGirl _pettyGirl):base(_pettyGirl)
        {
            
        }

        public Searcher(IGoodBodyGirl _goodBodyGirl):base(_goodBodyGirl)
        {

        }

        public Searcher(IGreatTemperamentGirl _greatTemperamentGirl)
            : base(_greatTemperamentGirl)
        {

        }

        public override void Show()
        {
            if(base.pettyGirl == null)
            {
                Console.WriteLine("对象为空，请赋值.");
                return;
            }

            Console.WriteLine("----------美女的信息如下：-------------------");
            base.pettyGirl.GoodLooking();

            base.pettyGirl.NiceFigure();

            base.pettyGirl.GreatTemperament();
        }

        public override void ShowGoodBody()
        {
            if(base.goodBodyGirl == null)
            {
                Console.WriteLine("对象为空，请赋值.");
                return;
            }
            base.goodBodyGirl.GoodLooking();
            base.goodBodyGirl.NiceFigure();
        }
    }
}
