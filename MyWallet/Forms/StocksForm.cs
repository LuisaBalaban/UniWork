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
    public partial class StocksForm : Form
    {
        private string connectionString = "Data Source=databaseStocks.db";
        public List<Stocks> ListStocks;
        public List<Stocks> ListTesla;
        public List<Stocks> ListGoogle;
        public List<Stocks> ListApple;
        public List<Stocks> ListFacebook;
        private ListViewGroup _lvgTesla;
        private ListViewGroup _lvgGoogle;
        private ListViewGroup _lvgApple;
        private ListViewGroup _lvgFacebook;
        public StocksForm()
        {
            InitializeComponent();
            ListStocks = new List<Stocks>();
            ListTesla = new List<Stocks>();
            ListGoogle = new List<Stocks>();
            ListApple = new List<Stocks>();
            ListFacebook = new List<Stocks>();
        }
        private void DisplayStocks()
        {
            lvStocks.Items.Clear();
            foreach (Stocks s in ListStocks)
            {

                ListViewItem lvi = new ListViewItem(s.bussiness);
                lvi.SubItems.Add(Convert.ToInt32(s.amount).ToString());
                if (s.bussiness == "Apple")
                {
                    lvi.ImageKey = "Apple.png";
                    lvi.Group = _lvgApple;
                }
                else if (s.bussiness == "Facebook")
                {
                    lvi.ImageKey = "Facebook.png";
                    lvi.Group = _lvgFacebook;
                }
                else if (s.bussiness == "Tesla")
                {
                    lvi.ImageKey = "Tesla.png";
                    lvi.Group = _lvgTesla;
                }
                else if (s.bussiness == "Google")
                {
                    lvi.ImageKey = "Google.png";
                    lvi.Group = _lvgGoogle;
                }
                lvStocks.Items.Add(lvi);
                lvi.Tag = s;

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
                        string bussiness = null;
                        if (rbApple.Checked)
                        {
                            bussiness = rbApple.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            Stocks s = new Stocks(bussiness, amount);
                            ListApple.Add(s);
                            AddStocks(s);
                            //ListStocks.Add(s);
                            DisplayStocks();
                            tbApple.Visible = true;
                            float total = 0;
                            foreach (Stocks stock in ListApple)
                            {

                                total = (float)stock + total;

                            }
                            tbApple.Text = total.ToString();
                        }
                        else if (rbFacebook.Checked)
                        {
                            bussiness = rbFacebook.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            Stocks s = new Stocks(bussiness, amount);
                            ListFacebook.Add(s);
                            AddStocks(s);
                            //ListStocks.Add(s);
                            DisplayStocks();
                            tbFacebook.Visible = true;
                            float total = 0;
                            foreach (Stocks stock in ListFacebook)
                            {

                                total = (float)stock + total;

                            }
                            tbFacebook.Text = total.ToString();

                        }
                        else if (rbTesla.Checked)
                        {
                            bussiness = rbTesla.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            Stocks s = new Stocks(bussiness, amount);
                            ListTesla.Add(s);
                            AddStocks(s);
                            //ListStocks.Add(s);
                            DisplayStocks();
                            tbTesla.Visible = true;
                            float total = 0;
                            foreach (Stocks stock in ListTesla)
                            {

                                total = (float)stock + total;

                            }
                            tbTesla.Text = total.ToString();

                        }
                        else if (rbGoogle.Checked)
                        {
                            bussiness = rbGoogle.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            Stocks s = new Stocks(bussiness, amount);
                            ListGoogle.Add(s);
                            AddStocks(s);
                            //ListStocks.Add(s);
                            DisplayStocks();
                            tbTesla.Visible = true;
                            float total = 0;
                            foreach (Stocks stock in ListGoogle)
                            {

                                total = (float)stock + total;

                            }
                            tbGoogle.Text = total.ToString();


                        }
                        tbAmount.Text = string.Empty;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("An exception appeared!");
                    }

                }
            }
        }

        private void StocksForm_Load(object sender, EventArgs e)
        {
            try
            {
                _lvgApple = new ListViewGroup("Apple", HorizontalAlignment.Left);
                _lvgFacebook = new ListViewGroup("Facebook", HorizontalAlignment.Left);
                _lvgTesla = new ListViewGroup("Tesla", HorizontalAlignment.Left);
                _lvgGoogle = new ListViewGroup("Google", HorizontalAlignment.Left);

               _lvgApple.Header = "Apple";
                _lvgFacebook.Header = "Facebook";
                _lvgTesla.Header = "Tesla";
                _lvgGoogle.Header = "Google";
                _lvgApple.Name = "lvgApple";
                _lvgFacebook.Name = "lvgFacebook";
                _lvgTesla.Name = "lvgTesla";
                _lvgGoogle.Name = "lvgGoogle";
                lvStocks.Groups.AddRange(new[] { _lvgApple, _lvgFacebook, _lvgTesla, _lvgGoogle });

                LoadStocks();
                DisplayStocks();

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
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        string bussiness = null;
                        if (rbApple.Checked)
                        {
                            bussiness = rbApple.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim()) * -1;
                            Stocks s = new Stocks(bussiness, amount);
                            if (amount < int.Parse(tbApple.Text.Trim()) * -1)
                            {
                                MessageBox.Show("Impossible transaction - your don't have enough Apple stocks ");
                            }
                            else if (amount >= int.Parse(tbApple.Text.Trim()) * -1)
                            {
                                ListApple.Add(s);
                                //AddCrypto(s);
                                ListStocks.Add(s);
                                DisplayStocks();
                                tbApple.Visible = true;
                                float total = 0;
                                foreach (Stocks stock in ListApple)
                                {
                                    total = (float)stock + total;
                                }
                                tbApple.Text = total.ToString();
                            }
                        }
                        else if (rbFacebook.Checked)
                        {
                            bussiness = rbFacebook.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim()) * -1;
                            Stocks s = new Stocks(bussiness, amount);
                            if (amount < int.Parse(tbFacebook.Text.Trim()) * -1)
                            {
                                MessageBox.Show("Impossible transaction - your don't have enough Facebook stocks ");
                            }
                            else if (amount >= int.Parse(tbFacebook.Text.Trim()) * -1)
                            {
                                ListFacebook.Add(s);
                                //AddCrypto(s);
                                ListStocks.Add(s);
                                DisplayStocks();
                                tbFacebook.Visible = true;
                                float total = 0;
                                foreach (Stocks stock in ListFacebook)
                                {
                                    total = (float)stock + total;
                                }
                                tbFacebook.Text = total.ToString();
                            }
                        }
                        else if (rbTesla.Checked)
                        {
                            bussiness = rbTesla.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim()) * -1;
                            Stocks s = new Stocks(bussiness, amount);
                            if (amount < int.Parse(tbTesla.Text.Trim()) * -1)
                            {
                                MessageBox.Show("Impossible transaction - your don't have enough Tesla stocks ");
                            }
                            else if (amount >= int.Parse(tbTesla.Text.Trim()) * -1)
                            {
                                ListTesla.Add(s);
                                //AddCrypto(s);
                                ListStocks.Add(s);
                                DisplayStocks();
                                tbTesla.Visible = true;
                                float total = 0;
                                foreach (Stocks stock in ListTesla)
                                {
                                    total = (float)stock + total;
                                }
                                tbTesla.Text = total.ToString();
                            }
                        }
                        else if (rbGoogle.Checked)
                        {
                            bussiness = rbGoogle.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim() )* -1;
                            Stocks s = new Stocks(bussiness, amount);
                            if (amount < int.Parse(tbGoogle.Text.Trim()) * -1)
                            {
                                MessageBox.Show("Impossible transaction - your don't have enough Google stocks ");
                            }
                            else if (amount >= int.Parse(tbGoogle.Text.Trim()) * -1)
                            {
                                ListGoogle.Add(s);
                                //AddCrypto(s);
                                ListStocks.Add(s);
                                DisplayStocks();
                                tbTesla.Visible = true;
                                float total = 0;
                                foreach (Stocks stock in ListGoogle)
                                {
                                    total = (float)stock + total;
                                }
                                tbGoogle.Text = total.ToString();

                            }

                        }
                        tbAmount.Text = string.Empty;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An exception appeared!");
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbApple.Checked)
            {
                string bussiness = "Apple";
                WebBrowserForm w1 = new WebBrowserForm(bussiness);
                w1.Show();
            }
            else if (rbFacebook.Checked)
            {
                string bussiness = "Facebook";
                WebBrowserForm w1 = new WebBrowserForm(bussiness);
                w1.Show();
            }
            else if (rbTesla.Checked)
            {
                string bussiness = "Tesla";
                WebBrowserForm w1 = new WebBrowserForm(bussiness);
                w1.Show();
            }
            else if (rbGoogle.Checked)
            {
                string bussiness = "Google";
                WebBrowserForm w1 = new WebBrowserForm(bussiness);
                w1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbApple.Checked)
            {
                string bussiness = "Apple";
                string demand = "info";
                WebBrowserForm w1 = new WebBrowserForm(bussiness,demand);
                w1.Show();
            }
            else if (rbFacebook.Checked)
            {
                string bussiness = "Facebook";
                string demand = "info";
                WebBrowserForm w1 = new WebBrowserForm(bussiness, demand);
                w1.Show();
            }
            else if (rbTesla.Checked)
            {
                string bussiness = "Tesla";
                string demand = "info";
                WebBrowserForm w1 = new WebBrowserForm(bussiness, demand);
                w1.Show();
            }
            else if (rbGoogle.Checked)
            {
                string bussiness = "Google";
                string demand = "info";
                WebBrowserForm w1 = new WebBrowserForm(bussiness, demand);
                w1.Show();
            }
        }
        private void AddStocks(Stocks s)
        {
            var queryString = "INSERT INTO Stocks (Bussiness, Amount) " + "VALUES (@bussiness, @amount); ";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@bussiness", s.bussiness);
                command.Parameters.AddWithValue("@amount", s.amount);
                connection.Open();
                try
                {
                    command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ListStocks.Add(s);

            }
        }
        private void LoadStocks()
        {
            var query = "SELECT * FROM Stocks";
            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var bussiness = (string)reader["Bussiness"];
                        var amount = Convert.ToInt32(reader["Amount"]);
                        Stocks s= new Stocks(bussiness, amount);
                        ListStocks.Add(s);
                        if (s.bussiness == "Facebook")
                        {
                            ListFacebook.Add(s);
                            tbFacebook.Visible = true;
                            float total = 0;
                            foreach (Stocks stock in ListFacebook)
                            {

                                total = (float)stock + total;

                            }
                            tbFacebook.Text = total.ToString();
                        }
                        else if (s.bussiness=="Apple")
                        {
                            ListApple.Add(s);
                            tbApple.Visible = true;
                            float total = 0;
                            foreach (Stocks stock in ListApple)
                            {

                                total = (float)stock + total;

                            }
                            tbApple.Text = total.ToString();
                        }
                        else if (s.bussiness == "Tesla")
                        {
                            ListTesla.Add(s);
                            tbTesla.Visible = true;
                            float total = 0;
                            foreach (Stocks stock in ListTesla)
                            {

                                total = (float)stock + total;

                            }
                            tbTesla.Text = total.ToString();
                        }
                        else if (s.bussiness == "Google")
                        {
                            ListGoogle.Add(s);
                            tbGoogle.Visible = true;
                            float total = 0;
                            foreach (Stocks stock in ListGoogle)
                            {

                                total = (float)stock + total;

                            }
                            tbGoogle.Text = total.ToString();
                        }


                    }
                }


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
    }
}
