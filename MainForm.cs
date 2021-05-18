using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShares_Click(object sender, EventArgs e)
        {
            this.Hide();
            Share_Portofolium share_Portofolium = new Share_Portofolium();
            share_Portofolium.FormClosed += (s, args) => this.Close();
            share_Portofolium.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers customers = new Customers();
            customers.FormClosed += (s, args) => this.Close();
            customers.Show();
        }

        private void btnBVB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bvb.ro/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.ro/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facebook.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCharts formCharts = new FormCharts();
            formCharts.FormClosed += (s, args) => this.Close();
            formCharts.Show();
        }
    }
}
