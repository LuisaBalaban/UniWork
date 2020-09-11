using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet
{
    [Serializable]
    public class Investments
    {
        public string type { get; set; }
        public int amount { get; set; }
        public string name { get; set; }
        public string additionalInfo { get; set; }
        public Investments()
        {

        }
        public Investments(string type, int initialAmount, string name, string info)
        {
            this.additionalInfo = additionalInfo;
            this.amount = initialAmount;
            this.name = name;
            this.type = type;
        }

    }
}
