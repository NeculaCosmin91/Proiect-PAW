using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Proiect_PAW
{

    public partial class EditCustomers : Form
    {
        private readonly Customer customer;
        public EditCustomers(Customer customers)
        {
            InitializeComponent();
            customer = customers;
        }

        private void EditCustomers_Load(object sender, EventArgs e)
        {
            tbName.Text = customer.Name;
            tbSurname.Text = customer.Surname;
            tbSerial.Text = customer.Serial;
            tbNumber.Text = Convert.ToString(customer.Number);
            
        }

        private void btnAddNewC_Click(object sender, EventArgs e)
        {
            
            customer.Name = tbName.Text;
            customer.Surname = tbSurname.Text;
            customer.Serial = tbSerial.Text;
            customer.Number = Convert.ToInt32(tbNumber.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
