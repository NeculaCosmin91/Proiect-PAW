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

namespace Proiect_PAW
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbuser.Text.Trim()=="" && tbpass.Text.Trim()=="")
            {
                MessageBox.Show("Empty Field", "Error");
            }
            else
            {
                string query = "SELECT * FROM Login WHERE Username=@Username AND Password=@Password";
                SQLiteConnection connection= new SQLiteConnection("Data source=DBproiect.db");
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", tbuser.Text);
                command.Parameters.AddWithValue("@Password", tbpass.Text);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if(dataTable.Rows.Count>0)
                {
                    MessageBox.Show("You are Logged in", "Login Successefu");

                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Login failed", "Error");
                }

            }




        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
