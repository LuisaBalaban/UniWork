using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet
{
    class InvalidDate:Exception
    {
        public DateTime transactionTime { get; set; }
        
        public InvalidDate(DateTime transactionTime)
        {
            
            this.transactionTime = transactionTime;
        }
        public override string Message
        {
            get
            {
                return "The transaction date entered -" + transactionTime + "- is invalid!";
            }
        }
    }
}
