using MyWallet.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWallet
{
    public partial class InvestForm : Form
    {
        public InvestForm()
        {
            InitializeComponent();
        }

        private void saveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.investing.com/news/");
        }

        private void investToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceForm b2 = new BalanceForm();
            b2.Show();
        }

        private void exportStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm tr1 = new TransactionForm();
            tr1.Show();
        }

        private void cmsCrypto_Opening(object sender, CancelEventArgs e)
        {
            Process.Start("https://www.coindesk.com/");
        }

        private void cmsStocks_Opening(object sender, CancelEventArgs e)
        {
            Process.Start("https://www.marketwatch.com/");
        }

        private void cmsBonds_Opening(object sender, CancelEventArgs e)
        {
            Process.Start("https://www.marketwatch.com/column/bond-report");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CryptoForm c1 = new CryptoForm();
            c1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StocksForm s1 = new StocksForm();
            s1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OthersForm b1 = new OthersForm();
            b1.Show();
        }
    }
}
