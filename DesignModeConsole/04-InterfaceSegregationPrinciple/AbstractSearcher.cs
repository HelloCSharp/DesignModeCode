using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.ISP
{
    public abstract class AbstractSearcher
    {
        //protected IPettyGirl pettyGirl;

        //public AbstractSearcher(IPettyGirl _pettyGirl)
        //{
        //    this.pettyGirl = _pettyGirl;
        //}

        protected PettyGirl pettyGirl;

        public AbstractSearcher(PettyGirl _pettyGirl)
        {
            this.pettyGirl = _pettyGirl;
        }

        protected IGreatTemperamentGirl greatTemperamentGirl;
        public AbstractSearcher(IGreatTemperamentGirl _greatTemperamentGirl)
        {
            this.greatTemperamentGirl = _greatTemperamentGirl;
        }

        protected IGoodBodyGirl goodBodyGirl;
        public AbstractSearcher(IGoodBodyGirl _goodBodyGirl)
        {
            this.goodBodyGirl = _goodBodyGirl;
        }

        public abstract void Show();

        public abstract void ShowGoodBody();

    }
}
