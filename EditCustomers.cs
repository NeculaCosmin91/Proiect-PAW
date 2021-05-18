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

        private readonly SQLiteConnection connection;
        private string ConnectionString = "Data source=DBproiect.db";
        private readonly SQLiteDataAdapter adapter;

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
            if (MessageBox.Show("Are you sure?", " Change Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    EditCustomer(customer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }

        private void EditCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        private void EditCustomer(Customers customer)
        {

            string update = "Update Customers SET Name=@Name, Surname=@Surname, Serial=@Serial, Number=@Number WHERE " +
                "Id=@Id";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(update, connection);
                command.Parameters.Add(
                        new SQLiteParameter("@Name", DbType.String, "Name"));
                command.Parameters.Add(
                    new SQLiteParameter("@Surname", DbType.String, "Surname"));
                command.Parameters.Add(
                    new SQLiteParameter("@Serial", DbType.String, "Serial"));
                command.Parameters.Add(
                    new SQLiteParameter("@Number", DbType.Int32, "Number"));
                

                command.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
