using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.PP
{
    public class Mail:ICloneable
    {

        /// <summary>
        /// 收件人
        /// </summary>
        public string Receiver{get;set;}

        /// <summary>
        /// 主题
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// 称谓
        /// </summary>
        public string Appellation { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Context { get; set; }
        
        /// <summary>
        /// 邮件的尾部，签名
        /// </summary>
        public string Tail { get; set; }


        public Mail(AdvTemplate advTemplate)
        {
            this.Context = advTemplate.GetAdvContext();
            this.Subject = advTemplate.GetAdvSubject();

        }

        public object Clone()
        {
            Mail mail = null;
            try
            {
                mail = (Mail)base.MemberwiseClone();
            }
            catch (Exception ex)
            {
                
                throw;
            }

            return mail;
        }
    }
}
