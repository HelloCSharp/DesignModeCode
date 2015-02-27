using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.PP
{
    public class Client
    {
        private static int MAX_COUNT = 6;

        public static void Test()
        {
            int i = 0;
            Mail mail = new Mail(new AdvTemplate())
            {
                Tail = "XX银行版权所有"
            };

            while(i < MAX_COUNT)
            {
                Mail cloneMail = mail.Clone() as Mail;

                cloneMail.Appellation = GetRandString(5) + "先生(女士)";
                cloneMail.Receiver = GetRandString(5) + "@" + GetRandString(8) + ".com";

                SendMail(cloneMail);
                i++;
            }


            Console.ReadKey();
            
        }


        public static void SendMail(Mail mail)
        {
            Console.WriteLine("标题：" + mail.Subject + " \t收件人：" + mail.Receiver + "\t...发送成功！");
        }

        public static string GetRandString(int maxLength)
        {
            string source = "abcdefghijklmnopqrstovwxyzABCDEFGHIJKLMNOPQRSTOVWXYZ";
            var sources = source.ToArray();
            StringBuilder sb = new StringBuilder();

            Random rand = new Random();
            for (int i = 0; i < maxLength; i++)
            {

                sb.Append(sources[rand.Next(sources.Length)]);
            }

            return sb.ToString();
        }


    }
}
