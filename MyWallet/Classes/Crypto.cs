using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet.Classes
{
    [Serializable]
    public class Crypto
    {
        public string currency {get; set;}
        public float amount { get; set; }

        public Crypto()
        {

        }
        public Crypto(string currency, float amount)
        {
            this.currency = currency;
            this.amount = amount;
        }
        public static explicit operator float(Crypto cr)
        {
            return cr.amount;
        }
        public static explicit operator double(Crypto cr)
        {
            return cr.amount;
        }


    }
}
