namespace LibraryApp
{
    partial class frmPerson
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(154, 208);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 52);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(27, 23);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(27, 56);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "LastName";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(27, 92);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 20);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(27, 123);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(142, 123);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(142, 89);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 27);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(142, 56);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(142, 23);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 8;
            // 
            // frmPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(397, 303);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnSave);
            Name = "frmPerson";
            Text = "Person";
            Load += frmPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
    }
}