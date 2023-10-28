using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemberClass member = new();
            ArrayList list1 = new();
            string res=ValidationCheck.IsValidNumber(txtMembershipID.Text); 
            int memeberShipID = int.Parse(res);
            member.MembershipID = memeberShipID;
            list1.Add(member.MembershipID);
            member.BorrowedBooks = ValidationCheck.IsValidInput(txtBorrowedBooks.Text);
            list1.Add(member.BorrowedBooks);
            DateTime borrowingDate = Convert.ToDateTime(txtBorrowingDate.Text);
            member.BorrowingDate = borrowingDate;
            list1.Add(borrowingDate);
            DateTime reternDate = Convert.ToDateTime(txtReturnDate.Text);
            member.ReturnDate= reternDate;
            list1.Add(reternDate);

        }
    }

}
