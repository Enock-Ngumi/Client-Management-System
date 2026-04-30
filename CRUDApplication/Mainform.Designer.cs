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
            btnAddPerson = new Button();
            btnUserManagement = new Button();
            btnChangePassword = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.White;
            btnAddPerson.FlatStyle = FlatStyle.Popup;
            btnAddPerson.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPerson.ForeColor = Color.Blue;
            btnAddPerson.Location = new Point(21, 95);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(329, 78);
            btnAddPerson.TabIndex = 0;
            btnAddPerson.Text = "ADD USER";
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click_1;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = Color.White;
            btnUserManagement.FlatStyle = FlatStyle.Popup;
            btnUserManagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserManagement.ForeColor = Color.FromArgb(0, 0, 192);
            btnUserManagement.Location = new Point(21, 224);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(329, 78);
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
            btnChangePassword.Location = new Point(21, 337);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(329, 78);
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
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 3;
            label1.Text = "CURRENT USER";
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnChangePassword);
            Controls.Add(btnUserManagement);
            Controls.Add(btnAddPerson);
            Name = "Mainform";
            Text = "Mainform";
            Load += Mainform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddPerson;
        private Button btnUserManagement;
        private Button btnChangePassword;
        private Label label1;
    }
}