using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Classes
{
    public class Others
    {
        public string currency { get; set; }
        public float amount { get; set; }
        public int id { get; set; }
       // public static int id = 0;

        public Others()
        {

        }
        public Others(string currency, float amount, int id)
        {
            this.currency = currency;
            this.amount = amount;
            this.id = id;
        }
        public static explicit operator float(Others o)
        {
            return o.amount;
        }
        


    }
}
