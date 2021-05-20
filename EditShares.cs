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
    public partial class EditShares : Form
    {
        private readonly Shares actiune;
        public EditShares(Shares shares)
        {
            InitializeComponent();
            actiune = shares;
        }

        private void EditShares_Load(object sender, EventArgs e)
        {
            tbNameShare.Text = actiune.Name;
            tbPriceShare.Text =Convert.ToString(actiune.Price);
            tbCompanyShare.Text = actiune.Company;
      
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            actiune.Name = tbNameShare.Text;
            actiune.Price = Convert.ToInt32(tbPriceShare.Text);
            actiune.Company = tbCompanyShare.Text;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
