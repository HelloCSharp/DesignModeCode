using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.COR
{
    public abstract class Handler
    {
        public static int FATHER_LEVEL_REQUEST = 1;
        public static int HUSBAND_LEVEL_REQUEST = 2;
        public static int SON_LEVEL_REQUEST = 3;

        private int level = 0;

        private Handler nextHandler;

        public Handler(int _level)
        {
            this.level = _level;
        }

        public void HandleMessage(IWomen women)
        {
            if(women.GetWomenType() == this.level)
            {
                this.Response(women);
            }
            else
            {
                if(this.nextHandler != null)
                {
                    this.nextHandler.HandleMessage(women);
                }
                else
                {
                    Console.WriteLine("---没地方请示了，按不同意处理---");
                }
            }
        }


        public void SetNext(Handler _handler)
        {
            this.nextHandler = _handler;
        }


        protected abstract void Response(IWomen women);

        
    }
}
