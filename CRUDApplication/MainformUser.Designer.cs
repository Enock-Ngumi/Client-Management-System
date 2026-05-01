namespace Client_Management_System
{
    partial class MainformUser
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
            list = new Button();
            btnAddUser = new Button();
            btnEditUser = new Button();
            ChangePassword = new Button();
            LogOut = new Button();
            panelcontainer = new Panel();
            label1 = new Label();
            btnMyProfile = new Button();
            SuspendLayout();
            // 
            // list
            // 
            list.BackColor = Color.White;
            list.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            list.ForeColor = Color.Maroon;
            list.Location = new Point(47, 99);
            list.Name = "list";
            list.Size = new Size(196, 53);
            list.TabIndex = 0;
            list.Text = "CLIENT LIST";
            list.UseVisualStyleBackColor = false;
            list.Click += list_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.White;
            btnAddUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.Maroon;
            btnAddUser.Location = new Point(47, 183);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(196, 46);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "ADD CLIENT";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.White;
            btnEditUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditUser.ForeColor = Color.Maroon;
            btnEditUser.Location = new Point(47, 257);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(196, 56);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "EDIT CLIENT";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // ChangePassword
            // 
            ChangePassword.BackColor = Color.White;
            ChangePassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangePassword.ForeColor = Color.Maroon;
            ChangePassword.Location = new Point(47, 354);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(196, 61);
            ChangePassword.TabIndex = 3;
            ChangePassword.Text = "CHANGE PASSWORD";
            ChangePassword.UseVisualStyleBackColor = false;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.White;
            LogOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.Maroon;
            LogOut.Location = new Point(47, 450);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(196, 53);
            LogOut.TabIndex = 4;
            LogOut.Text = "LOG OUT";
            LogOut.UseVisualStyleBackColor = false;
            // 
            // panelcontainer
            // 
            panelcontainer.Location = new Point(399, 127);
            panelcontainer.Name = "panelcontainer";
            panelcontainer.Size = new Size(1166, 627);
            panelcontainer.TabIndex = 5;
            panelcontainer.Paint += panelcontainer_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 0;
            label1.Text = "CURRENT USER";
            // 
            // btnMyProfile
            // 
            btnMyProfile.BackColor = Color.White;
            btnMyProfile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyProfile.ForeColor = Color.FromArgb(0, 64, 64);
            btnMyProfile.Location = new Point(85, 47);
            btnMyProfile.Name = "btnMyProfile";
            btnMyProfile.Size = new Size(104, 32);
            btnMyProfile.TabIndex = 6;
            btnMyProfile.Text = "My Profile";
            btnMyProfile.UseVisualStyleBackColor = false;
            btnMyProfile.Click += btnMyProfile_Click;
            // 
            // MainformUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 627);
            Controls.Add(btnMyProfile);
            Controls.Add(label1);
            Controls.Add(panelcontainer);
            Controls.Add(LogOut);
            Controls.Add(ChangePassword);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
            Controls.Add(list);
            Name = "MainformUser";
            Text = "MainformUser";
            Load += MainformUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button list;
        private Button btnAddUser;
        private Button btnEditUser;
        private Button ChangePassword;
        private Button LogOut;
        private Panel panelcontainer;
        private Label label1;
        private Button btnMyProfile;
    }
}