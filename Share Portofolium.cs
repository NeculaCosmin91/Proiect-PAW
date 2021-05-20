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
using System.Configuration;
using System.Globalization;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Windows;




namespace Proiect_PAW
{
    public partial class Share_Portofolium : Form
    {

        private readonly SQLiteConnection connection;
        private string ConnectionString = "Data source=DBproiect.db";
        private readonly SQLiteDataAdapter adapter;
        private readonly DataSet dataSet;
        SQLiteDataReader dr;

        
        private List<Shares> shares;
        public Share_Portofolium()
        {
            InitializeComponent();
            shares = new List<Shares>();

            
        }

        private void btnAddShare_Click(object sender, EventArgs e)
        {
            string Name = tbNameShare.Text;
            float Price = float.Parse(tbPriceShare.Text);
            string Company = tbCompanyShare.Text;

            bool formValid = true;
            if (Name.Trim().Length < 2)
            {
                errorProvider1.SetError(tbNameShare, "Minim 2 characters");
                formValid = true;
            }
            if (Company.Trim().Length < 2)
            {
                errorProvider1.SetError(tbCompanyShare, "Minim 2 characters");
                formValid = true;
            }
            if (!formValid)
            {
                MessageBox.Show("Form contains errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Shares actiune = new Shares(Name, Price, Company);
            AddNewShare(actiune);

            DisplayShare();

            tbNameShare.Text = string.Empty;
            tbPriceShare.Text = string.Empty;
            tbCompanyShare.Text = string.Empty;
        }

        private void Share_Portofolium_Load(object sender, EventArgs e)
        {
            try
            {
                var query = "SELECT * FROM Shares ORDER BY Name";
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    SQLiteCommand comanda = new SQLiteCommand(query, connection);
                    connection.Open();
                    using (SQLiteDataReader reader = comanda.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["Name"]);
                        }
                        reader.Close();
                        connection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            try
            {
              
                LoadShares();
                DisplayShare();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddNewShare(Shares actiune)
        {
            var query = "Insert INTO shares(Name, Price, Company)" +
                " VALUES(@Name, @Price, @Company);" + "SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, connection);
                comanda.Parameters.AddWithValue("@Name", actiune.Name);
                comanda.Parameters.AddWithValue("@Price", actiune.Price);
                comanda.Parameters.AddWithValue("@Company", actiune.Company);


                connection.Open();

                actiune.Id = (long)comanda.ExecuteScalar();


                shares.Add(actiune);

            }
        }
       
        private void LoadShares()
        {
            var query = "SELECT * FROM Shares";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand comanda = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = comanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["id"];
                        string Name = (string)reader["Name"];
                        float Price = float.Parse(reader["Price"].ToString()); 
                        
                        string Company = (string)reader["Company"];

                        Shares actiune = new Shares(id, Name, Price, Company);
                        shares.Add(actiune);
                    }
                }
            }
        }

        public void DisplayShare()
        {
            lvShares.Items.Clear();

            foreach (Shares S in shares)
            {
                ListViewItem item = new ListViewItem(S.Name);
                item.SubItems.Add(S.Price.ToString());
                item.SubItems.Add(S.Company);

                lvShares.Tag = shares;

                item.Tag = S;

                lvShares.Items.Add(item);


            }

        }

        private void tbNameShare_Validating(object sender, CancelEventArgs e)
        {
            if (tbNameShare.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(tbNameShare, "Minim 2 characters");
            }
            else
                errorProvider1.SetError(tbNameShare, null);
        }

        private void tbCompanyShare_Validating(object sender, CancelEventArgs e)
        {
            if (tbCompanyShare.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(tbCompanyShare, "Minim 2 characters");
            }
            else
                errorProvider1.SetError(tbCompanyShare, null);
        }

        private void tbPriceShare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter serializare = new BinaryFormatter();
            using (FileStream fs = File.Create("Shares.bin"))
            {
                serializare.Serialize(fs, shares);
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter deserializare = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("Shares.bin"))
            {
                shares = (List<Shares>)deserializare.Deserialize(fs);
            }
            DisplayShare();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV | *.csv";
            saveFile.Title = "Export as csv";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    sw.WriteLine("Name, Price, Company");

                    foreach (Shares s in shares)
                    {
                        sw.WriteLine($"{s.Name}, {s.Price.ToString()},{s.Company} ");
                    }
                }
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);

            int curentY = printDocument.DefaultPageSettings.Margins.Top;

            while (IndexCurentPrint < shares.Count)
            {
                Shares actiune = shares[IndexCurentPrint];

                e.Graphics.DrawString($"{actiune.Name} {actiune.Price} {actiune.Company}", font,
                    Brushes.Black, printDocument.DefaultPageSettings.Margins.Left,
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
        private int lastSearchLength;

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            IndexCurentPrint = 0;

        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreview.ShowDialog();
        }

        private void printTool_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

       
        private void btnDeleteShare_Click(object sender, EventArgs e)
        {
            if (lvShares.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a share");
                return;
            }
            if (MessageBox.Show("Are you sure?", " Delete Share", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem select = lvShares.SelectedItems[0];
                    Shares shares = (Shares)select.Tag;

                    DeleteSharest(shares);
                    DisplayShare();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteSharest(Shares actiune)
        {
            const string query = "DELETE FROM Shares WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                //Remove from the database
                SQLiteCommand comanda = new SQLiteCommand(query, connection);
                comanda.Parameters.AddWithValue("@id", actiune.Id);

                comanda.ExecuteNonQuery();

                shares.Remove(actiune);
            }
        }
        private void btnEditShares_Click(object sender, EventArgs e)
        {
            if (lvShares.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a share!");
            }
            else
            {
                ListViewItem selecteditem = lvShares.SelectedItems[0];
                Shares S = (Shares)selecteditem.Tag;

                EditShares edit = new EditShares(S);
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    Editshare(S);
                    DisplayShare();
                }
            }
        }
        private void Editshare(Shares S)
        {
            var query = "Update Shares SET Name = @Name, Price = @Price, Company = @Company " 
                 + " WHERE Id=" + S.Id + " ";


            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var comanda = new SQLiteCommand(query, connection);

                comanda.Parameters.AddWithValue("@Name", S.Name);
                comanda.Parameters.AddWithValue("@Price", S.Price);
                comanda.Parameters.AddWithValue("@Company", S.Company);
                

                comanda.ExecuteNonQuery();

            }

        }

        private void lvShares_DragEnter(object sender, DragEventArgs e)
        {

        }


        private void btnImport_Click(object sender, EventArgs e) 
        {
            //int size = -1;
            //DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            //if (result == DialogResult.OK) // Test result.
            //{
            //    string file = openFileDialog1.FileName;
            //    try
            //    {
            //        string text = File.ReadAllText(file);
            //        size = text.Length;
            //    }
            //    catch (IOException)
            //    {
            //    }
            //}

            FileStream file = File.Open("E:\\Shares.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string view = reader.ReadToEnd();

            reader.Close();
            file.Close();


            string[] array = view.Split(new char[] { ',' });

            //foreach (string arr in array)
            //{
            //    lvShares.Items.Add(arr);
            //}

            foreach (string arr in array)
            {

                ListViewItem item = new ListViewItem(arr);

                item.SubItems.Add(arr);
                item.SubItems.Add(arr);

                lvShares.Tag = shares;

                item.Tag = arr;

                lvShares.Items.Add(item);
            }


        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text) && tbSearch.Text.Length > lastSearchLength)
            {
                foreach (ListViewItem item in lvShares.Items)
                {
                    if (item.Text.ToLower().Contains(tbSearch.Text.ToLower()))
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        lvShares.Items.Remove(item);
                    }
                    if (lvShares.SelectedItems.Count == 1)
                    {
                        lvShares.Focus();
                    }
                    lastSearchLength = tbSearch.Text.Length;
                }
            }
            else
            {
                DisplayShare();
                Refresh();
            }
        }

        private void btnclipboard_Click(object sender, EventArgs e)
        {
           
            Clipboard.SetText("Simbol: " + tbNameShare.Text + ", " + "Price: " +tbPriceShare.Text + ", " + "Company: " + tbCompanyShare.Text);
        }

        private void tbNameShare_MouseDown(object sender, MouseEventArgs e)
        {
            tbNameShare.DoDragDrop(tbNameShare.Text, DragDropEffects.Copy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();
        }

        
    }
    

}
