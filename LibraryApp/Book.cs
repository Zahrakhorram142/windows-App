using System;
using System.Collections;
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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            
            BookClass book = new();
            string bookId=ValidationCheck.IsValidNumber(txtBookID.Text);
            int bookID=int.Parse(bookId);
            book.BookID = bookID;
            book.Name= ValidationCheck.IsValidInput(txtName.Text);
            book.Writer= ValidationCheck.IsValidInput(txtName.Text);
            book.Subject= ValidationCheck.IsValidInput(txtName.Text);
            book.Publishers= ValidationCheck.IsValidInput(txtName.Text);
            DateTime yearOfPublication = Convert.ToDateTime(txtYearOfPublication.Text);
            book.YearOfPublication = yearOfPublication;
            book.Edition= ValidationCheck.IsValidInput(txtName.Text);
        }
    }

    
}
