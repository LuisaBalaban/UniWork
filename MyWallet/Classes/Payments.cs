using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet
{
    [Serializable]
    public class Payments
    {
        public string receiverName { get; set; }
        public int receiverPhoneNr { get; set; }
        public float amountSent { get; set; }
        public string additionalInfo { get; set; }
        public  Payments()
            {
            }
        public Payments(string name, int nr, float amount, string info)
        {
            receiverName = name;
            receiverPhoneNr = nr;
            amountSent = amount;
            additionalInfo = info;
        }
    }
    }

