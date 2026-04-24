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
            label3 = new Label();
            btnChange = new Button();
            txtNew = new TextBox();
            txtConfirm = new TextBox();
            SuspendLayout();
            // 
            // txtNewpass
            // 
            txtNewpass.AutoSize = true;
            txtNewpass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewpass.ForeColor = Color.Navy;
            txtNewpass.Location = new Point(36, 58);
            txtNewpass.Name = "txtNewpass";
            txtNewpass.Size = new Size(175, 28);
            txtNewpass.TabIndex = 1;
            txtNewpass.Text = "NEW PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(36, 226);
            label3.Name = "label3";
            label3.Size = new Size(219, 28);
            label3.TabIndex = 2;
            label3.Text = "CONFIRM PASSWORD";
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
            txtNew.Location = new Point(291, 58);
            txtNew.Name = "txtNew";
            txtNew.Size = new Size(327, 27);
            txtNew.TabIndex = 5;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(291, 226);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(327, 27);
            txtConfirm.TabIndex = 6;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConfirm);
            Controls.Add(txtNew);
            Controls.Add(btnChange);
            Controls.Add(label3);
            Controls.Add(txtNewpass);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtNewpass;
        private Label label3;
        private Button btnChange;
        private TextBox txtNew;
        private TextBox txtConfirm;
    }
}