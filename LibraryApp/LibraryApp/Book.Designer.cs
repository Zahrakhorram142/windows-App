namespace LibraryApp
{
    partial class frmBook
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
            lblBookID = new Label();
            lblName = new Label();
            lblSubject = new Label();
            lblWriter = new Label();
            lblPublishers = new Label();
            lblYearOfPublication = new Label();
            lblEdition = new Label();
            txtedition = new TextBox();
            txtYearOfPublication = new TextBox();
            txtPublishers = new TextBox();
            txtWriter = new TextBox();
            txtSubject = new TextBox();
            txtName = new TextBox();
            txtBookID = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(212, 297);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 50);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Location = new Point(29, 25);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(62, 20);
            lblBookID.TabIndex = 1;
            lblBookID.Text = "Book ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(29, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(29, 91);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(58, 20);
            lblSubject.TabIndex = 3;
            lblSubject.Text = "Subject";
            // 
            // lblWriter
            // 
            lblWriter.AutoSize = true;
            lblWriter.Location = new Point(29, 123);
            lblWriter.Name = "lblWriter";
            lblWriter.Size = new Size(50, 20);
            lblWriter.TabIndex = 4;
            lblWriter.Text = "Writer";
            // 
            // lblPublishers
            // 
            lblPublishers.AutoSize = true;
            lblPublishers.Location = new Point(29, 157);
            lblPublishers.Name = "lblPublishers";
            lblPublishers.Size = new Size(75, 20);
            lblPublishers.TabIndex = 5;
            lblPublishers.Text = "Publishers";
            // 
            // lblYearOfPublication
            // 
            lblYearOfPublication.AutoSize = true;
            lblYearOfPublication.Location = new Point(29, 190);
            lblYearOfPublication.Name = "lblYearOfPublication";
            lblYearOfPublication.Size = new Size(135, 20);
            lblYearOfPublication.TabIndex = 6;
            lblYearOfPublication.Text = "Year Of Publication";
            // 
            // lblEdition
            // 
            lblEdition.AutoSize = true;
            lblEdition.Location = new Point(29, 219);
            lblEdition.Name = "lblEdition";
            lblEdition.Size = new Size(56, 20);
            lblEdition.TabIndex = 7;
            lblEdition.Text = "Edition";
            // 
            // txtedition
            // 
            txtedition.Location = new Point(170, 223);
            txtedition.Name = "txtedition";
            txtedition.Size = new Size(125, 27);
            txtedition.TabIndex = 8;
            // 
            // txtYearOfPublication
            // 
            txtYearOfPublication.Location = new Point(170, 190);
            txtYearOfPublication.Name = "txtYearOfPublication";
            txtYearOfPublication.Size = new Size(125, 27);
            txtYearOfPublication.TabIndex = 9;
            // 
            // txtPublishers
            // 
            txtPublishers.Location = new Point(170, 157);
            txtPublishers.Name = "txtPublishers";
            txtPublishers.Size = new Size(125, 27);
            txtPublishers.TabIndex = 10;
            // 
            // txtWriter
            // 
            txtWriter.Location = new Point(170, 124);
            txtWriter.Name = "txtWriter";
            txtWriter.Size = new Size(125, 27);
            txtWriter.TabIndex = 11;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(170, 91);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(125, 27);
            txtSubject.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 13;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(170, 25);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(125, 27);
            txtBookID.TabIndex = 14;
            // 
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(511, 371);
            Controls.Add(txtBookID);
            Controls.Add(txtName);
            Controls.Add(txtSubject);
            Controls.Add(txtWriter);
            Controls.Add(txtPublishers);
            Controls.Add(txtYearOfPublication);
            Controls.Add(txtedition);
            Controls.Add(lblEdition);
            Controls.Add(lblYearOfPublication);
            Controls.Add(lblPublishers);
            Controls.Add(lblWriter);
            Controls.Add(lblSubject);
            Controls.Add(lblName);
            Controls.Add(lblBookID);
            Controls.Add(btnSave);
            Name = "frmBook";
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblBookID;
        private Label lblName;
        private Label lblSubject;
        private Label lblWriter;
        private Label lblPublishers;
        private Label lblYearOfPublication;
        private Label lblEdition;
        private TextBox txtedition;
        private TextBox txtYearOfPublication;
        private TextBox txtPublishers;
        private TextBox txtWriter;
        private TextBox txtSubject;
        private TextBox txtName;
        private TextBox txtBookID;
    }
}