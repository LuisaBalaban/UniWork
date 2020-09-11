using MyWallet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWallet.Forms
{
    public partial class OthersForm : Form
    {
        private string connectionString = "Data Source = databaseOthers.db";

        public List<Others> ListOthers;
        public List<Others> ListBonds;
        public float total;
        public List<Others> ListRE;
        public List<Others> ListGold;
        private ListViewGroup _lvgBonds;
        private ListViewGroup _lvgRE;
        private ListViewGroup _lvgGold;
        public OthersForm()
        {
            ListOthers = new List<Others>();
            ListBonds = new List<Others>();
            ListRE = new List<Others>();
            ListGold = new List<Others>();
            InitializeComponent();

        }
        private void DisplayOthers()
        {
            lvOthers.Items.Clear();
            foreach (Others o in ListOthers)
            {
                ListViewItem lvi = new ListViewItem(o.currency);
                lvi.SubItems.Add(Convert.ToInt32(o.amount).ToString());
                if (o.currency == "Real Estate")
                {
                    lvi.ImageKey = "Real Estate.png";
                    lvi.Group = _lvgRE;
                }
                else if (o.currency == "Gold")
                {
                    lvi.ImageKey = "Gold.png";
                    lvi.Group = _lvgGold;
                }
                else if (o.currency == "Bonds")
                {
                    lvi.ImageKey = "Bonds.png";
                    lvi.Group = _lvgBonds;
                }

                lvOthers.Items.Add(lvi);
                lvi.Tag = o;

            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("The form contains errors!",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    try
                    {
                        string currency = null;
                        if (rbBonds.Checked)
                        {
                            currency = rbBonds.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            int id = ListOthers.Count();
                            Others o = new Others(currency, amount,id);
                            //ListOthers.Add(o);
                            ListBonds.Add(o);
                            AddOthers(o);
                            DisplayOthers();
                            tbBonds.Visible = true;
                            total = 0;
                            foreach (Others other in ListBonds)
                            {

                                total = (float)other + total;

                            }
                            tbBonds.Text = total.ToString();
                        }
                        else if (rbRealEstat.Checked)
                        {
                            currency = rbRealEstat.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            int id = ListOthers.Count();
                            Others o = new Others(currency, amount,id);
                            //ListOthers.Add(o);
                            AddOthers(o);
                            ListRE.Add(o);
                            DisplayOthers();
                            tbRE.Visible = true;
                            total = 0;
                            foreach (Others others in ListRE)
                            {

                                total = (float)others + total;

                            }
                            tbRE.Text = total.ToString();

                        }
                        else if (rbGold.Checked)
                        {
                            currency = rbGold.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            int id = ListOthers.Count();
                            Others o = new Others(currency, amount,id);
                            //ListOthers.Add(o);
                            AddOthers(o);
                            ListGold.Add(o);
                            DisplayOthers();
                            tbGold.Visible = true;
                            total = 0;
                            foreach (Others other in ListGold)
                            {

                                total = (float)other + total;

                            }
                            tbGold.Text = total.ToString();

                        }
                        tbAmount.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }

        private void OthersForm_Load(object sender, EventArgs e)
        {
            try
            {
                _lvgGold = new ListViewGroup("Gold", HorizontalAlignment.Left);
                _lvgRE = new ListViewGroup("Real Estate", HorizontalAlignment.Left);
                _lvgBonds = new ListViewGroup("Bonds", HorizontalAlignment.Left);

                _lvgGold.Header = "Gold";
                _lvgRE.Header = "Real Estate";
                _lvgBonds.Header = "Bonds";

                _lvgGold.Name = "lvgGold";
                _lvgRE.Name = "lvgRE";
                _lvgBonds.Name = "lvgBonds";

                lvOthers.Groups.AddRange(new[] { _lvgGold, _lvgRE, _lvgBonds });

                LoadOthers();
                DisplayOthers();

            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            {
                if (!ValidateChildren())
                {
                    MessageBox.Show("The form contains errors!",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    try
                    {
                        string currency = null;
                        if (rbBonds.Checked)
                        {
                            currency = rbBonds.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim()) * -1;
                            int id = ListOthers.Count();
                            Others o = new Others(currency, amount,id);
                            if (amount < int.Parse(tbBonds.Text.Trim()) * -1)
                            {
                                MessageBox.Show("Impossible transaction - your can't sell more Bonds back than you have.");
                            }
                            else if (amount >= int.Parse(tbBonds.Text.Trim()) * -1)
                            {
                                //ListOthers.Add(o);
                                AddOthers(o);
                                ListBonds.Add(o);
                                DisplayOthers();
                                tbGold.Visible = true;
                                float total = 0;
                                foreach (Others other in ListBonds)
                                {

                                    total = (float)other + total;

                                }
                                tbBonds.Text = total.ToString();
                            }
                        }
                        else if (rbRealEstat.Checked)
                        {
                            currency = rbRealEstat.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim()) * -1;
                            int id = ListOthers.Count();
                            Others o = new Others(currency, amount,id);
                            if (amount < int.Parse(tbRE.Text.Trim()) * -1)
                            {
                                MessageBox.Show("Impossible transaction - your can't sell more Real Estate back than you have.");
                            }
                            else if (amount >= int.Parse(tbRE.Text.Trim()) * -1)
                            {
                                // ListOthers.Add(o);
                                AddOthers(o);
                                ListRE.Add(o);
                                DisplayOthers();
                                tbRE.Visible = true;
                                float total = 0;
                                foreach (Others others in ListRE)
                                {

                                    total = (float)others + total;

                                }
                                tbRE.Text = total.ToString();
                            }
                        }
                        else if (rbGold.Checked)
                        {
                            currency = rbGold.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim()) * -1;
                            int id = ListOthers.Count();
                            Others o = new Others(currency, amount,id);
                            if (amount < int.Parse(tbGold.Text.Trim()) * -1)
                            {
                                MessageBox.Show("Impossible transaction - your can't sell more Gold than you have.");
                            }
                            else if (amount >= int.Parse(tbGold.Text.Trim()) * -1)
                            {
                                //ListOthers.Add(o);
                                AddOthers(o);
                                ListGold.Add(o);
                                DisplayOthers();
                                tbGold.Visible = true;
                                float total = 0;
                                foreach (Others other in ListGold)
                                {

                                    total = (float)other + total;

                                }
                                tbGold.Text = total.ToString();

                            }
                        }
                        tbAmount.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
        }
        private void LoadOthers()
        {
            var query = "SELECT * FROM Others";
            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var currency = (string)reader["Currency"];
                        var amount = Convert.ToInt32(reader["Amount"]);
                        var id= Convert.ToInt32(reader["Id"]);
                        Others s = new Others(currency, amount,id);
                        ListOthers.Add(s);
                        if (s.currency == "Gold")
                        {
                            ListGold.Add(s);
                            tbGold.Visible = true;
                            float total = 0;
                            foreach (Others other in ListGold)
                            {

                                total = (float)other + total;

                            }
                            tbGold.Text = total.ToString();
                        }
                         if (s.currency == "Real Estate")
                        {
                            ListRE.Add(s);
                            tbRE.Visible = true;
                            float total = 0;
                            foreach (Others other in ListRE)
                            {

                                total = (float)other + total;

                            }
                            tbRE.Text = total.ToString();
                        }
                         if (s.currency == "Bonds")
                        {
                            ListBonds.Add(s);
                            tbBonds.Visible = true;
                            float total = 0;
                            foreach (Others other in ListBonds)
                            {

                                total = (float)other + total;

                            }
                            tbBonds.Text = total.ToString();
                        }

                    }
                }

            }
        }
        private void AddOthers(Others o)
        {
            var queryString = "INSERT INTO Others (Currency, Amount, Id) " + "VALUES (@currency, @amount, @id); ";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@currency", o.currency);
                command.Parameters.AddWithValue("@amount", o.amount);
                command.Parameters.AddWithValue("@id", o.id);
                connection.Open();
                try
                {
                    command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ListOthers.Add(o);

            }
        }
        private void DeleteOther(Others o)
        {
            const string stringSql = "Delete from Others where Id = @id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@id", o.id);
                command.ExecuteNonQuery();
                ListOthers.Remove(o);
            }
        }
        private void UpdateOther(Others o)
        {
            var query = "UPDATE Others SET Currency=@currency, Amount=@amount " + " Where Id=@id";
            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@amount", o.amount);
                command.Parameters.AddWithValue("@currency", o.currency);
                command.Parameters.AddWithValue("@id", o.id);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (rbBonds.Checked)
            {
                string bussiness = "Bonds";
                WebBrowserForm w1 = new WebBrowserForm(bussiness);
                w1.Show();
            }
            else if (rbGold.Checked)
            {
                string bussiness = "Gold";
                WebBrowserForm w1 = new WebBrowserForm(bussiness);
                w1.Show();
            }
            else if (rbRealEstat.Checked)
            {
                string bussiness = "Real Estate";
                WebBrowserForm w1 = new WebBrowserForm(bussiness);
                w1.Show();
            }

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }




        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvOthers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Choose a transaction to edit");
            }

            ListViewItem lvi = lvOthers.SelectedItems[0];
            Others o = (Others)lvi.Tag;
            var initial = o.amount;
           // Others others = new Others(o.currency, o.amount, o.id);
            OtherEditForm editForm = new OtherEditForm(o);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                   UpdateOther(o);
                   DisplayOthers();
                if (o.currency=="Bonds")
                {
                    
                    float total = 0;
                    total = Convert.ToInt32(tbBonds.Text);
                    if (o.amount >= 0)
                    {
                        total = total + (float)o-initial;
                    }
                    else

                    { total = total -initial + (float)o; }
                    tbBonds.Text = total.ToString();
                }
                if (o.currency == "Gold")
                {
                    float total = 0;
                    total = Convert.ToInt32(tbGold.Text);
                    if (o.amount >= 0)
                    {
                        total = total + (float)o - initial;
                    }
                    else
                    { total = total - initial + (float)o; }
                    tbGold.Text = total.ToString();
                }
                if (o.currency == "Real Estate")
                {
                    float total = 0;
                    total = Convert.ToInt32(tbRE.Text);
                    if (o.amount >= 0)
                    {
                        total = total + (float)o - initial;
                    }
                    else
                    { total = total - initial + (float)o; }
                    tbRE.Text = total.ToString();
                }

              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string method = null;
            string demand = null;
            if (rbBonds.Checked)
            {
                method = "Bonds";
                demand = "history";
                WebBrowserForm e1 = new WebBrowserForm(method,demand);
                e1.Show();
            }
            if(rbGold.Checked)
            {
                method = "Gold";
                demand = "history";
                WebBrowserForm e1 = new WebBrowserForm(method,demand);
                e1.Show();
            }
            if(rbRealEstat.Checked)
            {
                method = "Real Estate";
                demand = "history";
                WebBrowserForm e1 = new WebBrowserForm(method,demand);
                e1.Show();
            }


        }

        private void tbAmount_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbAmount, null);
        }

        private void tbAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAmount.Text))
            {
                errorProvider1.SetError(tbAmount, "Mandatory!");
                e.Cancel = true;
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (lvOthers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Choose a transaction to delete");
            }
            else if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //deleting participant
                ListViewItem lvi = lvOthers.SelectedItems[0];
                Others other = (Others)lvi.Tag;
                // ListOthers.Remove(other);
                if (other.currency == "Bonds")
                {
                    float total = 0;
                    foreach (Others o in ListBonds)
                    {

                        total = (float)other + total;

                    }

                    tbBonds.Text = total.ToString();

                }
                if (other.currency == "Gold")
                {

                    float total = 0;
                    total = Convert.ToInt32(tbGold.Text);
                    if (other.amount >= 0)
                    {
                        total = total - (float)other;
                    }
                    else
                        total = total + (float)other;
                    tbGold.Text = total.ToString();

                }
                if (other.currency == "Real Estate")
                {

                    float total = 0;
                    total = Convert.ToInt32(tbRE.Text);
                    if (other.amount >= 0)
                    {
                        total = total - (float)other;
                    }
                    else
                        total = total + (float)other;
                    tbRE.Text = total.ToString();

                }
                DeleteOther(other);
                DisplayOthers();
            }
        }
    }
}



