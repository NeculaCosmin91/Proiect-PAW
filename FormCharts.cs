using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Configuration;

namespace Proiect_PAW
{
    public partial class FormCharts : Form
    {

       
       
        
        
        public FormCharts()
        {
            InitializeComponent();
        }

        private void FormCharts_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("https://bvb.ro/");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = e.Url.ToString() + "Is Loading...";
        }

        private void btnALR_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/FinancialInstruments/Details/FinancialInstrumentsDetails.aspx?s=ALR");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/FinancialInstruments/Details/FinancialInstrumentsDetails.aspx?s=TLV");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void tradinviewcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tradingview.com/");
        }

        private void capitalcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://capital.com/");
        }

        private void currencycomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://currency.com/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/");
        }

        private void btnBRD_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/FinancialInstruments/Details/FinancialInstrumentsDetails.aspx?s=BRD");
        }

        private void btnBVB_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/FinancialInstruments/Details/FinancialInstrumentsDetails.aspx?s=BVB");
        }

        private void btnTEL_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/FinancialInstruments/Details/FinancialInstrumentsDetails.aspx?s=TEL");
        }

        private void btnCOTE_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/FinancialInstruments/Details/FinancialInstrumentsDetails.aspx?s=TEL");
        }

        private void btnDIGI_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/FinancialInstruments/Details/FinancialInstrumentsDetails.aspx?s=TEL");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://bvb.ro/FinancialInstruments/Details/FinancialInstrumentsDetails.aspx?s=M");
        }
    }
}
