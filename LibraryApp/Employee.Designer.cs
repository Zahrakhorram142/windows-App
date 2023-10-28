namespace LibraryApp
{
    partial class frmEmployee
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
            lblNationalCode = new Label();
            lblEmployeeCode = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNumber = new Label();
            lblAddress = new Label();
            lblEmployeementDate = new Label();
            txtEmployeementDate = new TextBox();
            txtAddress = new TextBox();
            TxtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtEmployeeCode = new TextBox();
            txtNationalCode = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Location = new Point(32, 34);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(105, 20);
            lblNationalCode.TabIndex = 0;
            lblNationalCode.Text = "National Code";
            // 
            // lblEmployeeCode
            // 
            lblEmployeeCode.AutoSize = true;
            lblEmployeeCode.Location = new Point(32, 71);
            lblEmployeeCode.Name = "lblEmployeeCode";
            lblEmployeeCode.Size = new Size(114, 20);
            lblEmployeeCode.TabIndex = 1;
            lblEmployeeCode.Text = "Employee Code";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(32, 107);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(76, 20);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(32, 144);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(75, 20);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "LastName";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(32, 178);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(104, 20);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(32, 209);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address";
            // 
            // lblEmployeementDate
            // 
            lblEmployeementDate.AutoSize = true;
            lblEmployeementDate.Location = new Point(32, 242);
            lblEmployeementDate.Name = "lblEmployeementDate";
            lblEmployeementDate.Size = new Size(145, 20);
            lblEmployeementDate.TabIndex = 6;
            lblEmployeementDate.Text = "Employeement Date";
            // 
            // txtEmployeementDate
            // 
            txtEmployeementDate.Location = new Point(190, 242);
            txtEmployeementDate.Name = "txtEmployeementDate";
            txtEmployeementDate.Size = new Size(125, 27);
            txtEmployeementDate.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(190, 209);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 8;
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(190, 175);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.Size = new Size(125, 27);
            TxtPhoneNumber.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(190, 137);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(190, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 11;
            // 
            // txtEmployeeCode
            // 
            txtEmployeeCode.Location = new Point(190, 60);
            txtEmployeeCode.Name = "txtEmployeeCode";
            txtEmployeeCode.Size = new Size(125, 27);
            txtEmployeeCode.TabIndex = 12;
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(190, 27);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(125, 27);
            txtNationalCode.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(246, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 47);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(579, 372);
            Controls.Add(btnSave);
            Controls.Add(txtNationalCode);
            Controls.Add(txtEmployeeCode);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(TxtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtEmployeementDate);
            Controls.Add(lblEmployeementDate);
            Controls.Add(lblAddress);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblEmployeeCode);
            Controls.Add(lblNationalCode);
            Name = "frmEmployee";
            Text = "Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNationalCode;
        private Label lblEmployeeCode;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblAddress;
        private Label lblEmployeementDate;
        private TextBox txtEmployeementDate;
        private TextBox txtAddress;
        private TextBox TxtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEmployeeCode;
        private TextBox txtNationalCode;
        private Button btnSave;
    }
}