
namespace Client_Management_System
{
    partial class Login
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
            user = new Label();
            pass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnlog = new Button();
            btnforgot = new Button();
            SuspendLayout();
            // 
            // user
            // 
            user.AutoSize = true;
            user.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user.ForeColor = Color.Blue;
            user.Location = new Point(35, 89);
            user.Name = "user";
            user.Size = new Size(106, 28);
            user.TabIndex = 0;
            user.Text = "Username";
            
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass.ForeColor = Color.Blue;
            pass.Location = new Point(35, 216);
            pass.Name = "pass";
            pass.Size = new Size(101, 28);
            pass.TabIndex = 1;
            pass.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(235, 89);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(292, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(235, 212);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(292, 27);
            txtPass.TabIndex = 3;
            // 
            // btnlog
            // 
            btnlog.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlog.ForeColor = Color.FromArgb(255, 128, 0);
            btnlog.Location = new Point(35, 381);
            btnlog.Name = "btnlog";
            btnlog.Size = new Size(170, 40);
            btnlog.TabIndex = 4;
            btnlog.Text = "LOGIN";
            btnlog.UseVisualStyleBackColor = true;
            btnlog.Click += btnlog_Click;
            // 
            // btnforgot
            // 
            btnforgot.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnforgot.ForeColor = Color.FromArgb(255, 128, 0);
            btnforgot.Location = new Point(479, 381);
            btnforgot.Name = "btnforgot";
            btnforgot.Size = new Size(259, 40);
            btnforgot.TabIndex = 5;
            btnforgot.Text = "FORGOT PASSWORD";
            btnforgot.UseVisualStyleBackColor = true;
            btnforgot.Click += btnforgot_Click;

            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnforgot);
            Controls.Add(btnlog);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pass);
            Controls.Add(user);
            Name = "Login";
            Text = "LOGIN FORM";
            ResumeLayout(false);
            PerformLayout();
        }

      

        #endregion

        private Label user;
        private Label pass;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnlog;
        private Button btnforgot;
    }
}