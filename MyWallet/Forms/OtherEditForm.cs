using MyWallet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWallet.Forms
{
    public partial class OtherEditForm : Form
    {
        private readonly Others _other;
        public List<Others> ListOthers;
  

        public OtherEditForm(Others other, List<Others> o)

        {
            _other = other;
            ListOthers = o;
            InitializeComponent();
        }
        public OtherEditForm(Others other)

        {
            _other = other;
           
            InitializeComponent();
        }

        private void OtherEditForm_Load(object sender, EventArgs e)
        {
            
            tbAmount.Text = Convert.ToInt32(_other.amount).ToString();
            tbBussiness.Text = _other.currency;
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _other.amount = Convert.ToInt32(tbAmount.Text);

                _other.currency = tbBussiness.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
