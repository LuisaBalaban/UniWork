using MyWallet.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyWallet.Forms
{
    public partial class CryptoForm : Form
    {
        public List<Crypto> ListCryptos;
        public List<Crypto> ListBit;
        public List<Crypto> ListEth;
        private ListViewGroup _lvgBit;
        private ListViewGroup _lvgEth;

        private string connectionString = "Data Source=databaseCrypto.db";
        public CryptoForm()
        {
            InitializeComponent();
            ListCryptos = new List<Crypto>();
            ListEth = new List<Crypto>();
            ListBit = new List<Crypto>();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void DisplayCryptos()
        {
            lvCrypto.Items.Clear();
            foreach (Crypto cr in ListCryptos)
            {
               
                ListViewItem lvi = new ListViewItem(cr.currency);
                lvi.SubItems.Add(Convert.ToInt32(cr.amount).ToString());
                if (cr.currency == "Bitcoin")
                {
                    lvi.ImageKey = "bitcoin.png";
                    lvi.Group = _lvgBit;
                }
                else if (cr.currency == "Etherum")
                {
                    lvi.ImageKey = "etherum.png";
                    lvi.Group = _lvgEth;
                }
               

                lvCrypto.Items.Add(lvi);
                lvi.Tag = cr;

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
                        if (rbBitcoin.Checked)
                        {
                            currency = rbBitcoin.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            Crypto cr = new Crypto(currency, amount);
                            ListBit.Add(cr);
                            AddCrypto(cr);
                            DisplayCryptos();
                            tbBitcoin.Visible = true;
                            tbRVBit.Visible = true;
                            float total = 0;
                            foreach (Crypto crypto in ListBit)
                            {
                                
                                    total = (float)crypto + total;
                           
                            }
                            tbBitcoin.Text = total.ToString();
                            float val=total/ 10264;
                            tbRVBit.Text = val.ToString();
                        }
                        else if (rbEthereum.Checked)
                        {
                            currency = rbEthereum.Text.Trim();
                            int amount = int.Parse(tbAmount.Text.Trim());
                            Crypto cr = new Crypto(currency, amount);
                            ListEth.Add(cr);
                            AddCrypto(cr);
                            DisplayCryptos();
                            tbEth.Visible = true;
                            tbRVEth.Visible = true;
                            double total1 = 0;
                            foreach (Crypto crypto in ListEth)
                            {
                                
                                    total1 = (double)crypto + total1;
                               
                               
                            }
                            double val = total1 / 361;
                            tbRVEth.Text = val.ToString();
                            tbEth.Text = total1.ToString();
                           

                        }
                        tbAmount.Text = string.Empty;
                    }

                    //ListCryptos.Add(cr);

                    catch (Exception)
                    {
                        MessageBox.Show("An exception appeared!");
                    }

                }
            }
        }

        private void CryptoForm_Load(object sender, EventArgs e)
        {
            try
            {
                _lvgBit = new ListViewGroup("Bitcoin", HorizontalAlignment.Left);
                _lvgEth = new ListViewGroup("Etherum", HorizontalAlignment.Left);

                _lvgBit.Header = "Bitcoin";
                _lvgEth.Header = "Etherum";
                _lvgBit.Name = "lvgBit";
                _lvgEth.Name = "lvgEth";
                lvCrypto.Groups.AddRange(new[] { _lvgBit, _lvgEth });

                LoadCrypto();
                DisplayCryptos();

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
        private void AddCrypto(Crypto cr)
        {
            var queryString = "INSERT INTO Crypto (Currency, Amount) " + "VALUES (@currency, @amount); ";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@currency", cr.currency);
                command.Parameters.AddWithValue("@amount", cr.amount);
                connection.Open();
                try
                {
                    command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ListCryptos.Add(cr);

            }
        }
        private void LoadCrypto()
        {
            var query = "SELECT * FROM Crypto";
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
                        Crypto cr = new Crypto(currency, amount);
                        ListCryptos.Add(cr);
                        if (cr.currency == "Bitcoin")
                        {
                            ListBit.Add(cr);
                            tbBitcoin.Visible = true;
                            float total = 0;
                            foreach (Crypto crypto in ListBit)
                            {

                                total = (float)crypto + total;

                            }
                            float val = total / 10264;
                            tbRVBit.Text = val.ToString();
                            tbBitcoin.Text = total.ToString();
                        }
                        else 
                        {
                            ListEth.Add(cr);
                            tbEth.Visible = true;
                            tbRVEth.Visible = true;
                            float total = 0;
                            foreach (Crypto crypto in ListEth)
                            {

                                total = (float)crypto + total;

                            }
                            double val = total / 361;
                            tbRVEth.Text = val.ToString();
                            tbEth.Text = total.ToString();
                            
                        }

                      
                    }
                   
                }


            }
        }

        private void btnSell_Click(object sender, EventArgs e)
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
                    if (rbBitcoin.Checked)
                    {
                        currency = rbBitcoin.Text.Trim();
                        int amount = int.Parse(tbAmount.Text.Trim()) * -1;
                        Crypto cr = new Crypto(currency, amount);
                        if (amount < int.Parse(tbBitcoin.Text.Trim()) * -1)
                        {
                            MessageBox.Show("Impossible transaction - you don't have enough bitcoins!");
                        }
                        else if (amount >= int.Parse(tbBitcoin.Text.Trim()) * -1)
                        {
                            ListBit.Add(cr);
                            AddCrypto(cr);
                            DisplayCryptos();
                            tbBitcoin.Visible = true;
                            tbRVBit.Visible = true;
                            float total = 0;
                            foreach (Crypto crypto in ListBit)
                            {

                                total = (float)crypto + total;

                            }
                            float val = total / 10264;
                            tbRVBit.Text = val.ToString();
                            tbBitcoin.Text = total.ToString();
                        }
                    }
                    else if (rbEthereum.Checked)
                    {
                        currency = rbEthereum.Text.Trim();
                        int amount = int.Parse(tbAmount.Text.Trim()) * -1;
                        Crypto cr = new Crypto(currency, amount);
                        if (amount < int.Parse(tbEth.Text.Trim()) * -1)
                        {
                            MessageBox.Show("Impossible transaction - you don't have enough etherum!");
                        }
                        else if (amount >= int.Parse(tbEth.Text.Trim()) * -1)
                        {
                            ListEth.Add(cr);
                            AddCrypto(cr);
                            DisplayCryptos();
                            tbEth.Visible = true;
                            tbRVEth.Visible = true;
                            double total1 = 0;
                            foreach (Crypto crypto in ListEth)
                            {

                                total1 = (double)crypto + total1;


                            }
                            double val = total1 / 361;
                            tbRVEth.Text = val.ToString();
                            tbEth.Text = total1.ToString();

                        }
                        tbAmount.Text = string.Empty;
                    }
                }

                //ListCryptos.Add(cr);

                catch (Exception)
                {
                    MessageBox.Show("An exception appeared!");
                }

                }
            }

        private void CryptoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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



        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream stream = File.Create("serialized.bin"))
                {
                    formatter.Serialize(stream, ListCryptos);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }

    }

