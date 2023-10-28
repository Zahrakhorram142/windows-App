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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeClass employee = new();
            string resNational = ValidationCheck.IsValidNumber(txtNationalCode.Text);
            string resNationalCode = ValidationCheck.IsValidNationalCode(resNational);
            employee.NationalCode = resNationalCode;
            string result = ValidationCheck.IsValidNumber(txtEmployeeCode.Text);
            int employeeCode = int.Parse(result);
            employee.EmployeeId = employeeCode;
            employee.FirstName = ValidationCheck.IsValidInput(txtFirstName.Text);
            employee.LastName = ValidationCheck.IsValidInput(txtLastName.Text);
            string resPhone = ValidationCheck.IsValidNumber(TxtPhoneNumber.Text);
            string resPhoneNumber = ValidationCheck.IsValidPhoneNumber(resPhone);
            employee.PhoneNumber = resPhoneNumber;
            employee.Address = txtAddress.Text;
            DateTime employeementDate = Convert.ToDateTime(txtEmployeementDate.Text);
            employee.EmployeementDate = employeementDate;

        }
    }
}
