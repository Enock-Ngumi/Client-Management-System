namespace Client_Management_System
{
    partial class UserProfileForm
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
            firstname = new Label();
            lastname = new Label();
            email = new Label();
            phonenumber = new Label();
            dob = new Label();
            txtFirstName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtDob = new TextBox();
            txtLastName = new TextBox();
            SuspendLayout();
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.BackColor = Color.White;
            firstname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstname.ForeColor = Color.Blue;
            firstname.Location = new Point(27, 57);
            firstname.Name = "firstname";
            firstname.Size = new Size(119, 25);
            firstname.TabIndex = 0;
            firstname.Text = "FIRST NAME";
            firstname.Click += firstname_Click;
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.BackColor = Color.White;
            lastname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastname.ForeColor = Color.Blue;
            lastname.Location = new Point(27, 125);
            lastname.Name = "lastname";
            lastname.Size = new Size(114, 25);
            lastname.TabIndex = 1;
            lastname.Text = "LAST NAME";
            lastname.Click += label2_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.White;
            email.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.Blue;
            email.Location = new Point(30, 182);
            email.Name = "email";
            email.Size = new Size(67, 25);
            email.TabIndex = 2;
            email.Text = "EMAIL";
            // 
            // phonenumber
            // 
            phonenumber.AutoSize = true;
            phonenumber.BackColor = Color.White;
            phonenumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phonenumber.ForeColor = Color.Blue;
            phonenumber.Location = new Point(27, 235);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(158, 25);
            phonenumber.TabIndex = 3;
            phonenumber.Text = "PHONE NUMBER";
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.BackColor = Color.White;
            dob.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dob.ForeColor = Color.Blue;
            dob.Location = new Point(30, 298);
            dob.Name = "dob";
            dob.Size = new Size(146, 25);
            dob.TabIndex = 4;
            dob.Text = "DATE OF BIRTH";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(288, 57);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(353, 27);
            txtFirstName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(288, 235);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(353, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(288, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(353, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(288, 298);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(353, 27);
            txtDob.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(288, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(353, 27);
            txtLastName.TabIndex = 9;
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLastName);
            Controls.Add(txtDob);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstName);
            Controls.Add(dob);
            Controls.Add(phonenumber);
            Controls.Add(email);
            Controls.Add(lastname);
            Controls.Add(firstname);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            Load += UserProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstname;
        private Label lastname;
        private Label email;
        private Label phonenumber;
        private Label dob;
        private TextBox txtFirstName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtDob;
        private TextBox txtLastName;
    }
}