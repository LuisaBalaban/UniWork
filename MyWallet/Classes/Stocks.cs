using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Classes
{
    public class Stocks
    {
        public string bussiness { get; set; }
        public float amount { get; set; }

        public Stocks()
        {

        }
        public Stocks(string bussiness, float amount)
        {
            this.bussiness = bussiness;
            this.amount = amount;
        }
        public static explicit operator float(Stocks s)
        {
            return s.amount;
        }
        public static explicit operator double(Stocks s)
        {
            return s.amount;
        }
    }
}
