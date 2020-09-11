using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWallet
{
    public partial class BalanceForm : Form

    {
        private string connectionString = "Data Source=database.db";

        public List<Transactions> ListTransactions;
        public List<Category> ListCategories;
        public Transactions tr;
        private int _transacIndex;
        public BalanceForm()
        {

            InitializeComponent();
            ListTransactions = new List<Transactions>();
        }
        public BalanceForm(Transactions tag, List<Category> categs)
        {

            tr = tag;
            ListCategories = categs;
            InitializeComponent();
            ListTransactions = new List<Transactions>();
        }

        private void btnSaveUp_Click(object sender, EventArgs e)
        {
            rtbHabits.Visible = true;
            int total = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;
            int sum7 = 0;
            int sum8 = 0;
            string categ = null;
            foreach (Transactions tr in ListTransactions)
            {
                total = (int)tr + total;

                if (tr.category == "Food")
                {
                    sum1 = (int)tr + sum1;
                }
                else if (tr.category == "Clothing")
                {
                    sum2 = (int)tr + sum2;
                   
                }
                else if (tr.category == "House")
                {
                    sum3 = (int)tr + sum3;
                    


                }
                else if (tr.category == "Gas")
                {
                    sum4 = (int)tr + sum4;
              

                }
                else if (tr.category == "Leisure")
                {
                    sum5 = (int)tr + sum5;

                }
                else if (tr.category == "Medicine")
                {
                    sum6 = (int)tr + sum6;
                    

                }
                else if (tr.category == "Rent")
                {
                    sum7 = (int)tr + sum7;

                }
                else if (tr.category == "Electronics")
                {
                    sum8 = (int)tr + sum8;
                 

                }
               
               
            }
            this.chart1.Series["Food"].Points.AddXY("Food", sum1);
            this.chart1.Series["Clothing"].Points.AddXY("Clothing", sum2);
            this.chart1.Series["Electronics"].Points.AddXY("Electronics", sum8);
            this.chart1.Series["Rent"].Points.AddXY("Rent", sum7);
            this.chart1.Series["Medicine"].Points.AddXY("Medicine", sum6);
            this.chart1.Series["Leisure"].Points.AddXY("Leisure", sum5);
            this.chart1.Series["Gas"].Points.AddXY("Gas", sum4);
            this.chart1.Series["Household Items"].Points.AddXY("House", sum3);

            int[] numbers = { sum1, sum2, sum3, sum4, sum5, sum6, sum7, sum8 };
            int max = numbers.Max();
            if (max == sum1)
            {
                categ = "food";
            }
            else if (max == sum2)
            {
                categ = "clothing";
            }
            else if (max == sum3)
            {
                categ = "household items";
            }
            else if (max == sum4)
            {
                categ = "gas";
            }
            else if (max == sum5)
            {
                categ = "leisure";
            }
            else if (max == sum6)
            {
                categ = "medicine";
            }
            else if (max == sum7)
            {
                categ = "rent";
            }
            else if (max == sum8)
            {
                categ = "electronics";
            }
            rtbHabits.Text = "Your spending total is " + total.ToString() + " $ " +
                    " and you spent the following amount for each category " +
                    "Food: " + sum1.ToString() + " $ " + " Clothing: " + sum2.ToString() + " $ " +
                    " Household items: " + sum3.ToString() + " $ " + " Gas: " + sum4.ToString() + " $ " + " Leisure: " + sum5.ToString() + " $ "
                    + " Medicine: " + sum6.ToString() + " $ " + " Rent: " + sum7.ToString() + " $ " + " Electronics: " + sum8.ToString() + " $ " +
                    " You spent the most on " + categ + ": " + max.ToString() + " $ ";
            //  MessageBox.Show(string.Format("x", textBoxCompositeControl1.Text));

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
                    }
                }

            }
        }

        private void BalanceForm_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            //foreach (Transactions tr in ListTransactions)
            //{
            //    if (tr.category == "Leisure")
            //    {
                    
            //        this.chart1.Series["Leisure"].Points.AddXY(tr.category, tr.amount);
            //    }
            //    if (tr.category == "Rent")
            //    {
            //        this.chart1.Series["Rent"].Points.AddXY(tr.category, tr.amount);
            //    }
            //    if (tr.category == "Gas")
            //    {
            //        this.chart1.Series["Gas"].Points.AddXY(tr.category, tr.amount);
            //    }
            //    if (tr.category == "Food")
            //    {
            //        this.chart1.Series["Food"].Points.AddXY(tr.category, tr.amount);
            //    }
            //    if (tr.category == "Clothing")
            //    {
            //        this.chart1.Series["Clothing"].Points.AddXY(tr.category, tr.amount);
            //    }
            //    if (tr.category == "Electronics")
            //    {
            //        this.chart1.Series["Electronics"].Points.AddXY(tr.category, tr.amount);
            //    }
            //    if (tr.category == "Medicine")
            //    {
            //        this.chart1.Series["Medicine"].Points.AddXY(tr.category, tr.amount);
            //    }

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbRecom.Visible = true;
            int total = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;
            int sum7 = 0;
            int sum8 = 0;
            string Recomandation = null;
            foreach (Transactions tr in ListTransactions)
            {
                total = (int)tr + total;

                if (tr.category == "Food")
                {
                    sum1 = (int)tr + sum1;
                }
                else if (tr.category == "Clothing")
                {
                    sum2 = (int)tr + sum2;
                }
                else if (tr.category == "House")
                {
                    sum3 = (int)tr + sum3;
                }
                else if (tr.category == "Gas")
                {
                    sum4 = (int)tr + sum4;
                }
                else if (tr.category == "Leisure")
                {
                    sum5 = (int)tr + sum5;
                }
                else if (tr.category == "Medicine")
                {
                    sum6 = (int)tr + sum6;
                }
                else if (tr.category == "Rent")
                {
                    sum7 = (int)tr + sum7;
                }
                else if (tr.category == "Electronics")
                {
                    sum8 = (int)tr + sum8;
                }

            }
            int[] numbers = { sum1, sum2, sum3, sum4, sum5, sum6, sum7, sum8 };
            int max = numbers.Max();
            int min = numbers.Min();
            if (max != 0)
            {
                if (max == sum1)
                {
                    Recomandation = "You spend the most amount on food. You should try to avoid eating out." + " you spent " + sum1 * 100 / total + "% of your budget from the past period on food";
                }
                else if (max == sum2)
                {
                    Recomandation = "You spend the most amount on clothing. You should try to avoid shopping sprees."+ " You spent " + sum2 * 100 / total + "% of your budget from the past period on clothing";
                }
                else if (max == sum3)
                {
                    Recomandation = "You spend the most amount on household items. You should try to avoid shopping sprees."+" You spent " + sum3 * 100 / total + "% of your budget from the past period on Household items";

                }
                else if (max == sum4)
                {
                    Recomandation = "You spend the most amount on gas. You should try using public transportation more often."+ " You spent " + sum4 * 100 / total + "% of your budget from the past period on gas";

                }
                else if (max == sum5)
                {
                    Recomandation = "You spend the most amount on leisure. You should try to avoid spending money on fun items for a while."+ " You spent " + sum5 * 100 / total + "% of your budget from the past period on leisure";

                }
                else if (max == sum6)
                {
                    Recomandation = "You spend the most amount on medication. You should resume to buying only necesary medication."+ " You spent " + sum6 * 100 / total + "% of your budget from the past period on medicine";

                }
                else if (max == sum7)
                {
                    Recomandation = "You spend the most amount on rent. That's a good sign! Keep it up, or maybe change apartments" + " you spent " + sum7 * 100 / total + "% of your budget from the past period on rent";

                }
                else if (max == sum8)
                {
                    Recomandation = "You spend the most amount on electronics. You dont need another iphone, so resume from buying excessive electronics" + " you spent " + sum8 * 100 / total + "% of your budget from the past period on electronics";

                }
            }
            else Recomandation = "You don't have any registered transactions";

            rtbRecom.Text = Recomandation.ToString();
        }

        private void checkTheNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.regions.com/Insights/Personal/Personal-Finances/budgeting-and-saving/10-Best-Ways-to-Save-Money");
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Tahoma", 20);
            var pageSettings = printDocument1.DefaultPageSettings;
            var intPrintAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            var intPrintAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;
            if (printDocument1.DefaultPageSettings.Landscape)
            {
                var intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }
            RectangleF rectPrintingArea = new RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight);
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            int intLinesFilled;
            int intCharsFitted;
            e.Graphics.MeasureString(rtbHabits.Text.Substring(_transacIndex), font, new SizeF(intPrintAreaWidth, intPrintAreaHeight), fmt, out intCharsFitted, out intLinesFilled);
            e.Graphics.DrawString(rtbHabits.Text.Substring(_transacIndex), font, Brushes.Black, rectPrintingArea, fmt);
            _transacIndex += intCharsFitted;
            if (_transacIndex < rtbHabits.Text.Length)
                e.HasMorePages = true;
        }
    
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _transacIndex = 0;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while loading your document. Check if your computer is connected to a printer");
            }
        }

        private void tXTExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void cmsPrintRecom_Click(object sender, EventArgs e)
        {

            if (printDialog2.ShowDialog() == DialogResult.OK)
                printDocument2.Print();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Tahoma", 20);
            var pageSettings = printDocument1.DefaultPageSettings;
            var intPrintAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            var intPrintAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            var marginLeft = pageSettings.Margins.Left;
            var marginTop = pageSettings.Margins.Top;
            if (printDocument1.DefaultPageSettings.Landscape)
            {
                var intTemp = intPrintAreaHeight;
                intPrintAreaHeight = intPrintAreaWidth;
                intPrintAreaWidth = intTemp;
            }
            RectangleF rectPrintingArea = new RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight);
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            int intLinesFilled;
            int intCharsFitted;
            e.Graphics.MeasureString(rtbRecom.Text.Substring(_transacIndex), font, new SizeF(intPrintAreaWidth, intPrintAreaHeight), fmt, out intCharsFitted, out intLinesFilled);
            e.Graphics.DrawString(rtbRecom.Text.Substring(_transacIndex), font, Brushes.Black, rectPrintingArea, fmt);
            _transacIndex += intCharsFitted;
            if (_transacIndex < rtbRecom.Text.Length)
                e.HasMorePages = true;
        }

        private void pageSetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pageSetupDialog2.PageSettings = printDocument2.DefaultPageSettings;

            if (pageSetupDialog2.ShowDialog() == DialogResult.OK)
                printDocument2.DefaultPageSettings = pageSetupDialog2.PageSettings;
        }

        private void printDocument2_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _transacIndex = 0;
        }

        private void pagePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog2.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while loading your document. Check if your computer is connected to a printer");
            }
        }

        private void investToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvestForm i1 = new InvestForm();
            i1.Show();
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm t1 = new TransactionForm();
            t1.Show();
        }
    }
    }
    
  
