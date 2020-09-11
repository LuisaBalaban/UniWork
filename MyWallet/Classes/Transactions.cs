using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWallet
{
	[Serializable]
    public class Transactions
		
    {
		public string category { get; set; }
		public string item { get; set; }
        public DateTime date { get; set; }
		public int amount { get; set; }
		public string info { get; set; }
        private DateTime _transactionTime;
        public DateTime transactionTime
        {
			get
            {
                return _transactionTime;
            }
            set
            {
               
                if (value >= DateTime.Today)//||(DateTime.Today - value).TotalDays>7
                    throw new InvalidDate(value);
                _transactionTime = value;
            }
        }
	public Transactions (string category, string item, int amount, DateTime date, string info)
        {

            this.category = category;
            this.item = item;
            this.amount = amount;
            this.transactionTime = date;
            this.info = info;
            this.date = date;
          
        }
		public Transactions()
        {

        }
        public static explicit operator int(Transactions t)
        {
            return t.amount;
        }
    }
}
