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

namespace MyWallet.Forms
{
    public partial class WebBrowserForm : Form
    {
        public string business;
        public string demand;
        public WebBrowserForm(string business)
        {
            this.business = business;
            InitializeComponent();
        }
        public WebBrowserForm(string business, string demand)
        {
            this.business = business;
            this.demand = demand;
            InitializeComponent();
        }

        private void WebBrowserForm_Load(object sender, EventArgs e)
        {
            if (business == "Apple")
            {
                webBrowser1.Navigate("https://www.macrotrends.net/stocks/charts/AAPL/apple/stock-price-history");
                if (demand != null)
                {
                    webBrowser1.Navigate("https://investor.apple.com/stock-price/default.aspx");
                }
            }
            else if (business == "Google")
            {
                webBrowser1.Navigate("https://www.macrotrends.net/stocks/charts/GOOGL/alphabet/stock-price-history");
                if (demand != null)
                {
                    webBrowser1.Navigate("https://money.usnews.com/investing/stock-market-news/articles/alphabet-inc-googl-goog-stock");
                }
            }
            else if (business == "Tesla")
            {
                webBrowser1.Navigate("https://www.macrotrends.net/stocks/charts/TSLA/tesla/stock-price-history");
                if (demand != null)
                {
                    webBrowser1.Navigate("https://ir.tesla.com/stock-information");
                }
            }
            else if (business == "Facebook")
            {
                webBrowser1.Navigate("https://www.macrotrends.net/stocks/charts/FB/facebook/stock-price-history");
                if (demand != null)
                {
                    webBrowser1.Navigate("https://investor.fb.com/stock-information/default.aspx");
                }
            }
            else if (business == "Gold")
            {
                if (demand == "history")
                {
                    webBrowser1.Navigate("https://www.investopedia.com/articles/basics/08/invest-in-gold.asp");
                }
            }
            else if (business == "Bonds")
            {
                if (demand == "history")
                {
                    webBrowser1.Navigate("https://www.investor.gov/introduction-investing/investing-basics/investment-products/bonds-or-fixed-income-products/bonds");

                }
            }
            else if (business == "Real Estate")
            {
                if (demand == "history")
                {
                    webBrowser1.Navigate("https://www.investopedia.com/mortgage/real-estate-investing-guide/");
                }
            }
        }
    }
}
