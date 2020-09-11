using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyWallet
{
    public partial class TransactionForm : Form
    {
        private string connectionString = "Data Source=database.db";

        public List<Transactions> ListTransactions;
        public List<Category> ListCategories;
        public Transactions tr;
        private ListViewGroup _lvgFood;
        private ListViewGroup _lvgClothing;
        private ListViewGroup _lvgHousehold;
        private ListViewGroup _lvgLeisure;
        private ListViewGroup _lvgMedicine;
        private ListViewGroup _lvgGas;
        private ListViewGroup _lvgElectronics;
        private ListViewGroup _lvgRent;

        public TransactionForm(Transactions tag)
        {
            InitializeComponent();
            ListTransactions = new List<Transactions>();
            ListCategories = new List<Category>();
            tr = tag;
           
        }
        public TransactionForm(Transactions tag, List<Category> categs)
        {
            InitializeComponent();
            ListTransactions = new List<Transactions>();

            tr = tag;
            ListCategories = categs;
            
        }

        public TransactionForm()
        {
            InitializeComponent();
            ListCategories = new List<Category>();
            ListTransactions = new List<Transactions>();
           
        }
        private void DisplayTransactions()
        {
            lvTransactions.Items.Clear();

            foreach (Transactions transaction in ListTransactions)
            {
                var TransacCategs = ListCategories.First(x => x.Name == transaction.category);
              //  string TransacCategs = string.Join(",",transaction.category);
                ListViewItem lvi = new ListViewItem(transaction.category);

                lvi.SubItems.Add(transaction.item);
                lvi.SubItems.Add(Convert.ToInt32(transaction.amount).ToString());
                lvi.SubItems.Add(transaction.info);
                lvi.SubItems.Add(transaction.date.ToShortDateString());
                {
                    if (transaction.category == "Food")
                    {
                        lvi.ImageKey = "food.png";
                        lvi.Group = _lvgFood;
                    }
                    else if (transaction.category == "Household")
                    {
                        lvi.ImageKey = "house.png";
                        lvi.Group = _lvgHousehold;
                    }
                    else if (transaction.category == "Clothing")
                    {
                        lvi.ImageKey = "clothing.png";
                        lvi.Group = _lvgClothing;
                    }
                    else if (transaction.category == "Leisure")
                    {
                        lvi.ImageKey = "leisure.png";
                        lvi.Group = _lvgLeisure;
                    }
                    else if (transaction.category == "Medicine")
                    {
                        lvi.ImageKey = "medicine.png";
                        lvi.Group = _lvgMedicine;
                    }
                    else if (transaction.category == "Gas")
                    {
                        lvi.ImageKey = "gas.png";
                        lvi.Group = _lvgGas;
                    }
                    else if (transaction.category == "Electronics")
                    {
                        lvi.ImageKey = "gas.png";
                        lvi.Group = _lvgElectronics;
                    }
                    else
                    {
                        lvi.ImageKey = "rent.png";
                        lvi.Group = _lvgRent;
                    }
                }

                lvTransactions.Items.Add(lvi);
               lvi.Tag = transaction;
                

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                try { 
                string category = cbCategory.Text.Trim();
                string item = tbItem.Text.Trim();
                int amount = int.Parse(tbAmount.Text.Trim());
                DateTime time = dtpDateTime.Value;
                string otherInfo = tbInfo.Text.Trim();
                var tr = new Transactions(category, item, amount, time, otherInfo);
                    //ListTransactions.Add(tr);
                AddTransactions(tr);
                    //ListTransactions.Add(tr);
                DisplayTransactions();
                }
                catch(InvalidDate ex)
                {
                    MessageBox.Show(string.Format("The date is invalid!"));
                }
                catch(Exception)
                {
                    MessageBox.Show("An exception appeared!");
                }
                tbAmount.Text = tbInfo.Text=tbItem.Text= string.Empty;
               // dtpDateTime.Value = DateTime.Today;
            }
        }
        public void LoadCategories()
        {
            using (StreamReader reader = File.OpenText("Categories.txt"))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    var items = line.Split(' ');
                    var categ = new Category(items[0]);
                    ListCategories.Add(categ);

                }
            }
           
        }
        private void AddTransactions(Transactions tr)
        {
            var queryString = "INSERT INTO Transactions (Category, Item, Amount, Info, Date) " + " VALUES (@category, @item, @amount, @info, @date); " +
                        "SELECT last_insert_rowid()"; 
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(queryString, connection);
                command.Parameters.AddWithValue("@category", tr.category);
                command.Parameters.AddWithValue("@item", tr.item);
                command.Parameters.AddWithValue("@amount", tr.amount);
                command.Parameters.AddWithValue("@info", tr.info);
                command.Parameters.AddWithValue("@date", tr.date);
                
                try
                
                {
                    command.ExecuteScalar();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ListTransactions.Add(tr);

            }
        }
        private void LoadTransactions()
        {
            
                var query = "SELECT * FROM Transactions";
            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var category = (string)reader["Category"];
                        var item = (string)reader["Item"];
                        var amount = Convert.ToInt32(reader["Amount"]);
                        var info = (string)reader["Info"];
                        DateTime date = DateTime.Parse((string)reader["Date"]);


                        Transactions transactions = new Transactions(category, item, amount, date, info);
                       ListTransactions.Add(transactions);
                        //DisplayTransactions();
                    }
                }


            }
        }
        private void UpdateTransactions(Transactions tr)
        {
            var query = "UPDATE Transactions SET Item=@item, Amount=@amount, Info=@info, Date=@date" + "WHERE Category=@category";


            using (var connection = new SQLiteConnection(connectionString))
            {
                var command = new SQLiteCommand(query, connection);
             //   command.Parameters.AddWithValue("@category", tr.category);
                command.Parameters.AddWithValue("@item", tr.item);
                command.Parameters.AddWithValue("@amount", tr.amount);
                command.Parameters.AddWithValue("@info", tr.info);
                command.Parameters.AddWithValue("@date", tr.date);
                connection.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
           
        }


            private void DeleteTransac(Transactions tr)
        {
            const string stringSql = "Delete from Transactions where Category = @category";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@category", tr.category);
                command.ExecuteNonQuery();
                ListTransactions.Remove(tr);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvTransactions.SelectedItems.Count!=1)
            {
                MessageBox.Show("Choose an entry to edit!");
                return;
            }
            else
            {
                ListViewItem lvi = lvTransactions.SelectedItems[0];
                Transactions tr = (Transactions)lvi.Tag;
                Transactions newTransac = new Transactions(tr.category, tr.item, tr.amount, tr.date, tr.info);
                TransactionEditForm editForm = new TransactionEditForm(newTransac, ListCategories);
                if(editForm.ShowDialog()==DialogResult.OK)
                {
                    //ListTransactions.Remove(tr);
                    //ListTransactions.Add(tr);

                   DeleteTransac(tr);
                   AddTransactions(newTransac);
                   DisplayTransactions();

                   //UpdateTransactions(tr);
                    //
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvTransactions.SelectedItems.Count!=1)
            {
                MessageBox.Show("Choose one entry");

            }
            else if(MessageBox.Show("Are you sure?","Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                try
                {
                    ListViewItem lvi = lvTransactions.SelectedItems[0];
                    Transactions tr = (Transactions)lvi.Tag;
                    DeleteTransac(tr);
                    DisplayTransactions();
                    //DisplayTransactions();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            try
            {
                _lvgFood = new ListViewGroup("Food", HorizontalAlignment.Left);
                _lvgClothing = new ListViewGroup("Clothing", HorizontalAlignment.Left);
                _lvgHousehold = new ListViewGroup("Household", HorizontalAlignment.Left);
                _lvgElectronics = new ListViewGroup("Electronics", HorizontalAlignment.Left);
                _lvgMedicine = new ListViewGroup("Medicine", HorizontalAlignment.Left);
                _lvgLeisure = new ListViewGroup("Leisure", HorizontalAlignment.Left);
                _lvgRent = new ListViewGroup("Rent", HorizontalAlignment.Left);
                _lvgGas = new ListViewGroup("Gas", HorizontalAlignment.Left);
                
                _lvgFood.Header = "Food";
                _lvgRent.Header = "Rent";
                _lvgRent.Name = "lvgRent";
                _lvgFood.Name = "lvgFood";
                _lvgHousehold.Header = "House";
                _lvgHousehold.Name = "lvgHousehold";
                _lvgClothing.Header = "Clothing";
                _lvgClothing.Name = "lvgClothing";
                _lvgMedicine.Header = "Medicine";
                _lvgMedicine.Name = "lvgMedicine";
                _lvgElectronics.Header = "Electronics";
                _lvgElectronics.Name = "lvgElectronics";
                _lvgLeisure.Header = "Leisure";
                _lvgLeisure.Name = "lvgLeisure";
                _lvgGas.Header = "Gas";
                _lvgGas.Name = "lvgGas";
                lvTransactions.Groups.AddRange(new[] { _lvgFood, _lvgHousehold, _lvgMedicine, _lvgClothing, _lvgElectronics, _lvgGas, _lvgRent, _lvgLeisure });

                LoadCategories();
                LoadTransactions();
                cbCategory.DataSource = ListCategories;
                DisplayTransactions();
                
            }
            catch(InvalidCastException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void tbItem_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbItem, null);
        }

        private void tbItem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbItem.Text))
            {
                errorProvider1.SetError(tbItem, "Add an item!");
                e.Cancel = true;
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAmount.Text))
            {
                errorProvider1.SetError(tbAmount, "Mandatory!");
                e.Cancel = true;
            }
        }

        private void tbAmount_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbAmount, null);
        }

        private void xMLExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Transactions>));
            using (FileStream s = File.Create("SerializedXML.xml"))
            {
                serializer.Serialize(s, ListTransactions);
            }
        }

        private void tXTExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save as TXT file";
            dialog.Filter = "TXT File| *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
            
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    writer.WriteLine("Category, Item, Amount, Other Info");
                    foreach (Transactions tr in ListTransactions)
                        writer.WriteLine($"{tr.category},{tr.item},{tr.amount},{tr.info}");
                }
            }
        }

        private void checkTheNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.wsj.com/news/economy?mod=djmc_DGEcon&gclsrc=aw.ds&&gclid=CjwKCAjwkdL6BRAREiwA-kiczLvvV9o1XUMYQmz9YtOFjA4zdJ6gfEPb0_lPfy8qYqN50ZDtkpUV_xoCgnUQAvD_BwE");
        }

        private void investToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvestForm i1 = new InvestForm();
            i1.Show();
        }

        private void saveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceForm b1 = new BalanceForm();
            b1.Show();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
