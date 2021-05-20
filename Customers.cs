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
    public partial class Customers : Form

    {
        private readonly SQLiteConnection connection;
        private string ConnectionString = "Data source=DBproiect.db";
        private readonly SQLiteDataAdapter adapter;
        
        
        private List<Customer> customers;
        public Customers()
        {
            InitializeComponent();
            customers = new List<Customer>();
        }

        private void btnAddNewC_Click(object sender, EventArgs e)
        {
            string Name = tbName.Text;
            string Surname = tbSurname.Text;
            string Serial = tbSerial.Text;
            int Number = int.Parse(tbNumber.Text);

            bool formValid = true;
            if (Name.Trim().Length < 2)
            {
                errorProvider1.SetError(tbName, "Minim 2 caracters");
                formValid = false;
            }
            if (Surname.Trim().Length < 2)
            {
                errorProvider1.SetError(tbSurname, "Minim 2 caracters");
                formValid = false;
            }
            if (Serial.Trim().Length != 2)
            {
                errorProvider1.SetError(tbSerial, "Only 2 characters");
                formValid = false;
            }
            if (tbNumber.TextLength != 6)
            {
                errorProvider1.SetError(tbNumber, "6 digits");
                formValid = false;
            }
            if (!formValid)
            {
                MessageBox.Show("Form contains Errors!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer customer = new Customer(Name, Surname, Serial, Number);
            
            AddNewCustomer(customer);
            DisplayCustomers();

            tbName.Text = string.Empty;
            tbSurname.Text = string.Empty;
            tbSerial.Text = string.Empty;
            tbNumber.Text = string.Empty;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCustomers();
                DisplayCustomers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddNewCustomer(Customer customer)
        {
            var query = "Insert INTO customers(Name, Surname, Serial, Number)" +
               " VALUES(@Name, @Surname, @Serial, @Number);" + "SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, connection);
                comanda.Parameters.AddWithValue("@Name", customer.Name);
                comanda.Parameters.AddWithValue("@Surname", customer.Surname);
                comanda.Parameters.AddWithValue("@Serial", customer.Serial);
                comanda.Parameters.AddWithValue("@Number", customer.Number);
                connection.Open();
                customer.Id = (long)comanda.ExecuteScalar();
                customers.Add(customer);
            }
        }
        private void LoadCustomers()
        {
            var query = "SELECT * FROM customers";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = comanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long Id = (long)reader["Id"];
                        string Name = (string)reader["Name"];
                        string Surname = (string)reader["Surname"];
                        string Serial = (string)reader["Serial"];
                        int Number =int.Parse(reader["Number"].ToString()); 
                        
                        Customer customer = new Customer(Id, Name, Surname, Serial, Number);
                        customers.Add(customer);
                    }
                }
            }
        }
        public void DisplayCustomers()
        {
            lvCustomers.Items.Clear();
            foreach (Customer C in customers)
            {
                ListViewItem item = new ListViewItem(C.Name);
                item.SubItems.Add(C.Surname);
                item.SubItems.Add(C.Serial);
                item.SubItems.Add(C.Number.ToString());
                lvCustomers.Tag = customers;
                item.Tag = C;
                lvCustomers.Items.Add(item);
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);

            int curentY = printDocument1.DefaultPageSettings.Margins.Top;

            while (IndexCurentPrint < customers.Count)
            {
                Customer customer = customers[IndexCurentPrint];

                e.Graphics.DrawString($"{customer.Name} {customer.Surname} {customer.Serial} {customer.Number}", font,
                    Brushes.Black, printDocument1.DefaultPageSettings.Margins.Left,
                   curentY);
                curentY += 20;

                if (curentY > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    break;
                }

                IndexCurentPrint++;
            }

        }
        int IndexCurentPrint = 0;
        //private int lastSearchLength;

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            IndexCurentPrint = 0;
        }
        private void toolStripbtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a customer!");
            }
            else
            {
                ListViewItem selecteditem = lvCustomers.SelectedItems[0];
                Customer C = (Customer)selecteditem.Tag;

                EditCustomers edit = new EditCustomers(C);
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    EditCustomers(C);
                    DisplayCustomers();
                }
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void EditCustomers(Customer CS)
        {
            var query = "Update customers SET Name = @Name, Surname = @Surname, Serial = @Serial, " +
                "Number = @Number" + " WHERE Id=" + CS.Id + " ";


            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var comanda = new SQLiteCommand(query, connection);

                comanda.Parameters.AddWithValue("@Name", CS.Name);
                comanda.Parameters.AddWithValue("@Surname", CS.Surname);
                comanda.Parameters.AddWithValue("@Serial", CS.Serial);
                comanda.Parameters.AddWithValue("@Number", CS.Number);
                
                comanda.ExecuteNonQuery();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a share");
                return;
            }
            if (MessageBox.Show("Are you sure?", " Delete Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem select = lvCustomers.SelectedItems[0];
                    Customer customers = (Customer)select.Tag;

                    DeleteCustomer(customers);
                    
                    DisplayCustomers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteCustomer(Customer customer)
        {
            const string query = "DELETE FROM Customers WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                //Remove from the database
                SQLiteCommand comanda = new SQLiteCommand(query, connection);
                comanda.Parameters.AddWithValue("@id", customer.Id);

                comanda.ExecuteNonQuery();

                customers.Remove(customer);
            }
        }

        private void toCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV | *.csv";
            saveFile.Title = "Export as csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.WriteLine("Name, Surname, Serial, Number");

                    foreach (Customer c in customers)
                    {
                        sw.WriteLine($"{c.Name},{c.Surname},{c.Serial} {c.Number.ToString()} ");
                    }
                }
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(tbName, "Minim 2 characters");
            }
            else
                errorProvider1.SetError(tbName, null);
        }

        private void tbSurname_Validating(object sender, CancelEventArgs e)
        {
            if (tbSurname.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(tbSurname, "Minim 2 characters");
            }
            else
                errorProvider1.SetError(tbSurname, null);
        }

        private void tbSerial_Validating(object sender, CancelEventArgs e)
        {
            if (tbSerial.Text.Trim().Length != 2)
            {
                errorProvider1.SetError(tbSerial, "Serial is made of 2 characters");
            }
            else
                errorProvider1.SetError(tbSerial, null);
        }

        private void tbNumber_Validating(object sender, CancelEventArgs e)
        {
            if (tbNumber.TextLength != 6)
            {
                errorProvider1.SetError(tbNumber, "Number is made of 6 numbers");
            }
            else
                errorProvider1.SetError(tbNumber, null);
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
