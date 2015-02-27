using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.OCP
{
    /// <summary>
    ///     计算机书籍-新增业务品种
    /// </summary>
    public class ComputerBook:IComputerBook
    {
        private string name;

        private int price;

        private string author;

        private string scope;

        public ComputerBook(string _name, int _price, string _author,string _scope)
        {
            this.name = _name;
            this.price = _price;
            this.author = _author; 
            this.scope = _scope;
        }
        public string GetScope()
        {
            return scope;
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
