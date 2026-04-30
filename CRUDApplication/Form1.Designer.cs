namespace Client_Management_System

{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Delete = new Button();
            txtId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtDob = new TextBox();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnUpdate = new ToolStripButton();
            btnDelete = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(43, 526);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(255, 526);
            button2.Name = "button2";
            button2.Size = new Size(117, 44);
            button2.TabIndex = 1;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(511, 526);
            button3.Name = "button3";
            button3.Size = new Size(117, 44);
            button3.TabIndex = 2;
            button3.Text = "Read";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(736, 526);
            button4.Name = "button4";
            button4.Size = new Size(117, 44);
            button4.TabIndex = 3;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.Font = new Font("Segoe UI", 13.8F);
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(978, 526);
            Delete.Name = "Delete";
            Delete.Size = new Size(117, 44);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += button5_Click;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Font = new Font("Segoe UI", 13.8F);
            txtId.Location = new Point(43, 88);
            txtId.Name = "txtId";
            txtId.Size = new Size(36, 31);
            txtId.TabIndex = 5;
            txtId.Text = "ID";
            txtId.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(43, 157);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 6;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(43, 219);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(43, 280);
            label4.Name = "label4";
            label4.Size = new Size(70, 31);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(43, 345);
            label5.Name = "label5";
            label5.Size = new Size(168, 31);
            label5.TabIndex = 9;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(43, 408);
            label6.Name = "label6";
            label6.Size = new Size(142, 31);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth";
            label6.Click += label6_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13.8F);
            numericUpDown1.Location = new Point(455, 81);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(567, 38);
            numericUpDown1.TabIndex = 11;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 13.8F);
            txtFirstname.Location = new Point(455, 150);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(567, 38);
            txtFirstname.TabIndex = 12;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 13.8F);
            txtLastname.Location = new Point(455, 216);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(567, 38);
            txtLastname.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F);
            txtEmail.Location = new Point(455, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(567, 38);
            txtEmail.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 13.8F);
            txtPhone.Location = new Point(455, 345);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(567, 38);
            txtPhone.TabIndex = 15;
            // 
            // txtDob
            // 
            txtDob.Font = new Font("Segoe UI", 13.8F);
            txtDob.Location = new Point(455, 401);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(567, 38);
            txtDob.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(341, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(743, 289);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataError += dataGridView1_DataError_1;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnUpdate, btnDelete });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1107, 27);
            toolStrip1.TabIndex = 19;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 24);
            btnAdd.Text = "ADD";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(29, 24);
            btnUpdate.Text = "UPDATE";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(29, 24);
            btnDelete.Text = "DELETE";
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1107, 643);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(txtDob);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(Delete);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Client Management System";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Delete;
        private Label txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtDob;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnUpdate;
        private ToolStripButton btnDelete;
    }
}
