using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.OCP
{
    public static class BookStore
    {
        private static List<IBook> bookList = new List<IBook>(
            );

        static BookStore()
        {
            bookList.Add(new OffNovelBook("天龙八部", 3200, "金庸"));
            bookList.Add(new OffNovelBook("巴黎圣母院", 5600, "雨果"));
            bookList.Add(new OffNovelBook("悲催世界", 3500, "雨果"));
            bookList.Add(new OffNovelBook("金瓶梅", 4300, "兰陵笑笑生"));
            bookList.Add(new ComputerBook("Think in C#", 4300, "Bruce Eckel", "编程语言"));
        }

        public static void Test()
        {
            Console.WriteLine("-------------书店卖出去的书籍记录如下：--------------");
            foreach (IBook book in bookList)
            {
                Console.WriteLine(string.Format("书籍名称：{0} \t 书籍作者：{1} \t 书籍价格：{2}元 ",
                    book.GetName(),book.GetAuthor(),(book.GetPrice() / 100f)).ToString());
            }

            Console.ReadKey();
        }
    }
}
