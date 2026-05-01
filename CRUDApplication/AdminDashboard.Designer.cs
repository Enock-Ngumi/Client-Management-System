namespace Client_Management_System
{
    partial class AdminDashboard
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
            chkIsAdmin = new CheckBox();
            User = new Label();
            Pass = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnCreateUser = new Button();
            btnUnlockUser = new Button();
            dataGridViewUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.BackColor = Color.White;
            chkIsAdmin.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkIsAdmin.ForeColor = Color.Blue;
            chkIsAdmin.Location = new Point(27, 270);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(89, 27);
            chkIsAdmin.TabIndex = 0;
            chkIsAdmin.Text = "ADMIN";
            chkIsAdmin.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            User.AutoSize = true;
            User.BackColor = Color.White;
            User.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User.ForeColor = Color.Blue;
            User.Location = new Point(27, 56);
            User.Name = "User";
            User.Size = new Size(111, 25);
            User.TabIndex = 1;
            User.Text = "USERNAME";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.BackColor = Color.White;
            Pass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pass.ForeColor = Color.Blue;
            Pass.Location = new Point(27, 177);
            Pass.Name = "Pass";
            Pass.Size = new Size(112, 25);
            Pass.TabIndex = 2;
            Pass.Text = "PASSWORD";
            Pass.Click += label2_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(151, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(151, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(252, 27);
            txtUsername.TabIndex = 4;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.White;
            btnCreateUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateUser.ForeColor = Color.Green;
            btnCreateUser.Location = new Point(257, 270);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(122, 42);
            btnCreateUser.TabIndex = 5;
            btnCreateUser.Text = "CREATE USER";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // btnUnlockUser
            // 
            btnUnlockUser.BackColor = Color.White;
            btnUnlockUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUnlockUser.ForeColor = Color.Green;
            btnUnlockUser.Location = new Point(785, 473);
            btnUnlockUser.Name = "btnUnlockUser";
            btnUnlockUser.Size = new Size(170, 42);
            btnUnlockUser.TabIndex = 6;
            btnUnlockUser.Text = "UNLOCK USER";
            btnUnlockUser.UseVisualStyleBackColor = false;
            btnUnlockUser.Click += btnUnlockUser_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(586, 3);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(601, 443);
            dataGridViewUsers.TabIndex = 9;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 781);
            Controls.Add(dataGridViewUsers);
            Controls.Add(btnUnlockUser);
            Controls.Add(btnCreateUser);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(Pass);
            Controls.Add(User);
            Controls.Add(chkIsAdmin);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIsAdmin;
        private Label User;
        private Label Pass;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnCreateUser;
        private Button btnUnlockUser;
        private DataGridView dataGridViewUsers;
    }
}