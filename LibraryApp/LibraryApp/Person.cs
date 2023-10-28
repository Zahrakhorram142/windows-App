using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PersonClass person = new();
            person.FirstName = ValidationCheck.IsValidInput(txtFirstName.Text);
            person.LastName = ValidationCheck.IsValidInput(txtLastName.Text);
            string resPhone = ValidationCheck.IsValidNumber(txtPhoneNumber.Text);
            string phoneNumber = ValidationCheck.IsValidNumber(resPhone);
            person.PhoneNumber = phoneNumber;
            person.Address = txtAddress.Text;

        }

        private void frmPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
