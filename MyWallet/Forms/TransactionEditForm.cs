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
    public partial class TransactionEditForm : Form
    {
        private readonly Transactions _transaction;
        public List<Category> categories;


        public TransactionEditForm(Transactions tr, List<Category> categs)
        {
            _transaction = tr;
            categories = categs;
            InitializeComponent();
        }
        public TransactionEditForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _transaction.amount = Convert.ToInt32(tbAmount.Text);
                _transaction.category = cbCategory.Text;
                _transaction.item = tbItem.Text;
                _transaction.info = tbInfo.Text;              
                _transaction.date = dtpDateTime.Value;
            }
            catch (InvalidDate ex)
            {
                MessageBox.Show(string.Format("The date is invalid!"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void TransactionEditForm_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = categories;
            tbAmount.Text = Convert.ToInt32(_transaction.amount).ToString();
            cbCategory.Text = _transaction.category;
            tbItem.Text = _transaction.item;
            tbInfo.Text = _transaction.info;
            dtpDateTime.Value = _transaction.date;
            if(_transaction.category!=null)
            {
                try
                {
                    var category = categories.First(x => x.Name == _transaction.category);
                    cbCategory.SelectedItem = category;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                   

        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
