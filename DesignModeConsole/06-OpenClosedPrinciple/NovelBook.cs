using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.OCP
{
    public class NovelBook:IBook
    {
        private string name;

        private int price;

        private string author;

        public NovelBook(string _name,int _price,string _author)
        {
            this.name = _name;
            this.price = _price;
            this.author = _author;
        }

        public string GetName()
        {
            return name;
        }

        public virtual int GetPrice()
        {
            return price;
        }

        public string GetAuthor()
        {
            return author;
        }
    }
}
