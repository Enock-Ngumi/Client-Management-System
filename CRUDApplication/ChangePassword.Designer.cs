namespace Client_Management_System
{
    partial class ChangePassword
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
            txtNewpass = new Label();
            Confirmpass = new Label();
            btnChange = new Button();
            txtNew = new TextBox();
            txtConfirm = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNewpass
            // 
            txtNewpass.AutoSize = true;
            txtNewpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewpass.ForeColor = Color.Navy;
            txtNewpass.Location = new Point(45, 159);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.Size = new Size(175, 28);
            txtNewpass.TabIndex = 1;
            txtNewpass.Text = "NEW PASSWORD";
            // 
            // Confirmpass
            // 
            Confirmpass.AutoSize = true;
            Confirmpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Confirmpass.ForeColor = Color.Navy;
            Confirmpass.Location = new Point(36, 266);
            Confirmpass.Name = "Confirmpass";
            Confirmpass.Size = new Size(219, 28);
            Confirmpass.TabIndex = 2;
            Confirmpass.Text = "CONFIRM PASSWORD";
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChange.ForeColor = Color.Maroon;
            btnChange.Location = new Point(320, 363);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(157, 50);
            btnChange.TabIndex = 3;
            btnChange.Text = "CHANGE";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click_1;
            // 
            // txtNew
            // 
            txtNew.Location = new Point(291, 163);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(327, 27);
            txtNew.TabIndex = 5;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(291, 266);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(327, 27);
            txtConfirm.TabIndex = 6;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(291, 77);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(327, 27);
            txtUser.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(56, 76);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 9;
            label1.Text = "USERNAME";
            label1.Click += label1_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(txtConfirm);
            Controls.Add(txtNew);
            Controls.Add(btnChange);
            Controls.Add(Confirmpass);
            Controls.Add(txtNewpass);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtNewpass;
        private Label Confirmpass;
        private Button btnChange;
        private TextBox txtNew;
        private TextBox txtConfirm;
        private Label User;
        private TextBox txtUser;
        private Label label1;
    }
}