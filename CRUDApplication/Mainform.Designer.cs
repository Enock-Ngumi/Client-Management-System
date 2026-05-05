using System.Security;

namespace Client_Management_System
{
    partial class Mainform
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
            components = new System.ComponentModel.Container();
            btnUserManagement = new Button();
            btnChangePassword = new Button();
            label1 = new Label();
            btnAdmin = new Button();
            logout = new Button();
            button4 = new Button();
            inactivityTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.White;
            btnUserManagement.FlatStyle = FlatStyle.Popup;
            btnUserManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.FromArgb(0, 0, 192);
            btnUserManagement.Location = new Point(11, 179);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(225, 39);
            btnUserManagement.TabIndex = 1;
            btnUserManagement.Text = "USER MANAGEMENT";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnUserManagement_Click_1;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.White;
            btnChangePassword.FlatStyle = FlatStyle.Popup;
            btnChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.FromArgb(0, 0, 192);
            btnChangePassword.Location = new Point(12, 247);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(224, 48);
            btnChangePassword.TabIndex = 2;
            btnChangePassword.Text = "CHANGE PASSWORD";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 3;
            label1.Text = "CURRENT USER";
            label1.Click += label1_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.White;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.FromArgb(0, 0, 192);
            btnAdmin.Location = new Point(12, 56);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(224, 39);
            btnAdmin.TabIndex = 4;
            btnAdmin.Text = "ADMIN";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.White;
            logout.FlatStyle = FlatStyle.Popup;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Red;
            logout.Location = new Point(629, 399);
            logout.Name = "logout";
            logout.Size = new Size(146, 39);
            logout.TabIndex = 6;
            logout.Text = "LOG OUT";
            logout.UseVisualStyleBackColor = false;
            logout.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(0, 0, 192);
            button4.Location = new Point(11, 115);
            button4.Name = "button4";
            button4.Size = new Size(224, 35);
            button4.TabIndex = 7;
            button4.Text = "CLIENT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // inactivityTimer
            // 
            inactivityTimer.Enabled = true;
            inactivityTimer.Interval = 60000;
            inactivityTimer.Tick += inactivityTimer_Tick;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(logout);
            Controls.Add(btnAdmin);
            Controls.Add(label1);
            Controls.Add(btnChangePassword);
            Controls.Add(btnUserManagement);
            Name = "Mainform";
            Text = "Mainform";
            Load += Mainform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUserManagement;
        private Button btnChangePassword;
        private Label label1;
        private Button btnAdmin;
        private Button logout;
        private Button button4;
        private System.Windows.Forms.Timer inactivityTimer;


    }
}