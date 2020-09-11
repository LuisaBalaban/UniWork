using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet
{
   public  class Category
    {
        public string Name { get; set; }
      
        public Category(string name)
        {
            Name = name;
            
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
