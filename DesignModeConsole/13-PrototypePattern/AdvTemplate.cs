using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.PP
{
    public class AdvTemplate
    {
        private string advSubject = "XX银行国庆信用卡抽奖活动";

        private string advContext = "国庆抽奖活动通知：只要刷卡就送你一百五！。。。";

        public string GetAdvSubject()
        {
            return this.advSubject;
        }

        public string GetAdvContext()
        {
            return this.advContext;
        }
    }
}
