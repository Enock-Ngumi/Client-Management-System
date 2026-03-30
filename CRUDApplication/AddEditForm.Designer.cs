namespace Client_Management_System
{
    partial class AddEditForm
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
            txtFirstname = new TextBox();
            txtDob = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastname = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(272, 38);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(422, 27);
            txtFirstname.TabIndex = 0;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(272, 317);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(422, 27);
            txtDob.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(272, 245);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(422, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(272, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(422, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(272, 108);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(422, 27);
            txtLastname.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 128, 0);
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 0, 192);
            btnSave.Location = new Point(291, 373);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 65);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 108);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 179);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 245);
            label4.Name = "label4";
            label4.Size = new Size(171, 31);
            label4.TabIndex = 10;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 317);
            label5.Name = "label5";
            label5.Size = new Size(148, 31);
            label5.TabIndex = 11;
            label5.Text = "Date of Birth";
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtLastname);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtDob);
            Controls.Add(txtFirstname);
            Name = "AddEditForm";
            Text = "CLIENT FILL FORM";
            Load += AddEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstname;
        private TextBox txtDob;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastname;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}