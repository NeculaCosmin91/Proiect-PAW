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
    public partial class AuthorisezConsultants : Form
    {
        private List<Consultanti> consultants;
        public AuthorisezConsultants()
        {
            InitializeComponent();
            consultants = new List<Consultanti>();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnAddConsultant_Click(object sender, EventArgs e)
        {
            string Institution = tbInstitution.Text;
            string Name = tbName.Text;
            string Surname = tbSurname.Text;
            int Phone = int.Parse(tbPhone.Text);
            string Email = tbEmail.Text;

            bool formvalid = true;
            if(Institution.Trim().Length < 2)
            {
                errorProvider1.SetError(tbInstitution, "Minim 2 characters");
                formvalid = true;
            }
            if (tbPhone.TextLength != 10)
            {
                errorProvider1.SetError(tbPhone, "10 digits");
                formvalid = false;
            }
            if (!formvalid)
            {
                MessageBox.Show("Form contains errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
