using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Proiect_PAW
{
    public partial class ChartsForm : Form
    {
        //private readonly SQLiteConnection connection;
       // private string ConnectionString = "Data source=DBproiect.db";
        //private readonly SQLiteDataAdapter adapter;
        //private readonly DataSet dataSet;

        private List<IntermediariClass> intermediaris;
        public ChartsForm()
        {
            InitializeComponent();
            intermediaris = new List<IntermediariClass>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Position =int.Parse(tbYear.Text);
            string Institution = tbIntermediary.Text;
            int Value = int.Parse(tbValue.Text);



            tbYear.Text = string.Empty;
            tbIntermediary.Text = string.Empty;
            tbValue.Text = string.Empty;


        }

        private void ChartsForm_Load(object sender, EventArgs e)
        { //de rezolvat

           
        }
        

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

       
    }
}
