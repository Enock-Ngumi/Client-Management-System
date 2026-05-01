namespace Client_Management_System
{
    partial class RegisterForm
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
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            chkIsAdmin = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDob = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(0, 192, 0);
            btnRegister.Location = new Point(527, 827);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(221, 44);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(35, 72);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(35, 477);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(410, 72);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(257, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(410, 477);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(257, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(35, 553);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 5;
            label3.Text = "Confirm password";
            label3.Click += label3_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(410, 553);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(257, 27);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.BackColor = Color.White;
            chkIsAdmin.FlatStyle = FlatStyle.System;
            chkIsAdmin.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkIsAdmin.ForeColor = Color.Red;
            chkIsAdmin.Location = new Point(29, 827);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(102, 26);
            chkIsAdmin.TabIndex = 7;
            chkIsAdmin.Text = "ADMIN";
            chkIsAdmin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(35, 136);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 8;
            label4.Text = "First name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(35, 202);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 9;
            label5.Text = "Last name";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(35, 266);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.FlatStyle = FlatStyle.System;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(35, 404);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 11;
            label7.Text = "Date of birth";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.FlatStyle = FlatStyle.System;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(35, 335);
            label8.Name = "label8";
            label8.Size = new Size(136, 25);
            label8.TabIndex = 12;
            label8.Text = "Phone number";
            // 
            // txtDob
            // 
            txtDob.Location = new Point(410, 404);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(257, 27);
            txtDob.TabIndex = 13;
            txtDob.TextChanged += textBox1_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(410, 335);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(257, 27);
            txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(410, 266);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(410, 136);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(257, 27);
            txtFirstName.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(410, 202);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(257, 27);
            txtLastName.TabIndex = 17;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 893);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtDob);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(chkIsAdmin);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtConfirmPassword;
        private CheckBox chkIsAdmin;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDob;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
    }
}