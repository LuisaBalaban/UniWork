using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWallet
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            TransactionForm tr1 = new TransactionForm();
            tr1.Show();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            BalanceForm b1 = new BalanceForm();
            b1.Show();
        }

        private void btnSaveUp_Click(object sender, EventArgs e)
        {
            InvestForm i1 = new InvestForm();
            i1.Show();
        }

        
    }
}
