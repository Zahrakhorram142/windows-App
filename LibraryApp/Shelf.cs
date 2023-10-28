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
    public partial class frmShelf : Form
    {
        public frmShelf()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ShelfClass shelf = new ShelfClass();
            string res=ValidationCheck.IsValidNumber(txtShelfID.Text);
            int shelfId = int.Parse(res);
            shelf.ShelfID = shelfId;
            shelf.Floor = ValidationCheck.IsValidInput(txtFloor.Text);
            shelf.Title = ValidationCheck.IsValidInput(txtTitle.Text); ;
        }
    }
}
