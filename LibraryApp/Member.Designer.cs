namespace LibraryApp
{
    partial class frmMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            lblMembershipID = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            lblBorrowedBooks = new Label();
            lblBorrowingDate = new Label();
            lblReturnDate = new Label();
            txtMembershipID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtBorrowedBooks = new TextBox();
            txtBorrowingDate = new TextBox();
            txtReturnDate = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(262, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 45);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblMembershipID
            // 
            lblMembershipID.AutoSize = true;
            lblMembershipID.Location = new Point(29, 31);
            lblMembershipID.Name = "lblMembershipID";
            lblMembershipID.Size = new Size(111, 20);
            lblMembershipID.TabIndex = 1;
            lblMembershipID.Text = "Membership ID";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(29, 62);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(29, 94);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "LastName";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(29, 123);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 20);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(29, 154);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address";
            // 
            // lblBorrowedBooks
            // 
            lblBorrowedBooks.AutoSize = true;
            lblBorrowedBooks.Location = new Point(29, 186);
            lblBorrowedBooks.Name = "lblBorrowedBooks";
            lblBorrowedBooks.Size = new Size(114, 20);
            lblBorrowedBooks.TabIndex = 6;
            lblBorrowedBooks.Text = "BorrowedBooks";
            // 
            // lblBorrowingDate
            // 
            lblBorrowingDate.AutoSize = true;
            lblBorrowingDate.Location = new Point(29, 221);
            lblBorrowingDate.Name = "lblBorrowingDate";
            lblBorrowingDate.Size = new Size(114, 20);
            lblBorrowingDate.TabIndex = 7;
            lblBorrowingDate.Text = "Borrowing Date";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(29, 254);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(88, 20);
            lblReturnDate.TabIndex = 8;
            lblReturnDate.Text = "Return Date";
            // 
            // txtMembershipID
            // 
            txtMembershipID.Location = new Point(166, 28);
            txtMembershipID.Name = "txtMembershipID";
            txtMembershipID.Size = new Size(125, 27);
            txtMembershipID.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(166, 59);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(166, 91);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 11;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(166, 123);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(166, 156);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 13;
            // 
            // txtBorrowedBooks
            // 
            txtBorrowedBooks.Location = new Point(166, 188);
            txtBorrowedBooks.Name = "txtBorrowedBooks";
            txtBorrowedBooks.Size = new Size(125, 27);
            txtBorrowedBooks.TabIndex = 14;
            // 
            // txtBorrowingDate
            // 
            txtBorrowingDate.Location = new Point(166, 221);
            txtBorrowingDate.Name = "txtBorrowingDate";
            txtBorrowingDate.Size = new Size(125, 27);
            txtBorrowingDate.TabIndex = 15;
            // 
            // txtReturnDate
            // 
            txtReturnDate.Location = new Point(166, 254);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(125, 27);
            txtReturnDate.TabIndex = 16;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(600, 379);
            Controls.Add(txtReturnDate);
            Controls.Add(txtBorrowingDate);
            Controls.Add(txtBorrowedBooks);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtMembershipID);
            Controls.Add(lblReturnDate);
            Controls.Add(lblBorrowingDate);
            Controls.Add(lblBorrowedBooks);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblMembershipID);
            Controls.Add(btnSave);
            Name = "frmMember";
            Text = "Member";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblMembershipID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private Label lblBorrowedBooks;
        private Label lblBorrowingDate;
        private Label lblReturnDate;
        private TextBox txtMembershipID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtBorrowedBooks;
        private TextBox txtBorrowingDate;
        private TextBox txtReturnDate;
    }
}