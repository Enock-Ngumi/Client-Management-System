using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Management_System
{
    public partial class Login : Form
    {
        public string Username;
        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;

        public Login()
        {
            InitializeComponent();

        }

        public Login(string User)
        {
            InitializeComponent();
            user.Text = User;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            bool loginSuccess = false;

            if (!loginSuccess)
            {
                DialogResult result = MessageBox.Show("Wrong username or password.\nDo you want to reset your password?", "Login Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                
                if (result == DialogResult.Yes)
                {
                    ChangePassword form = new ChangePassword();
                    form.Username = username;
                    form.ShowDialog();
                }

                return;
            }
            if (username == "admin" && password == "0000")
            {
                MessageBox.Show("Login successful");

            }
            else
            {
                MessageBox.Show("Invalid username or password");
                AddEditForm form = new AddEditForm();
                form.Close();
                this.Close();


            }
            int count = 1;

            if (count == 1)
            {
                AddEditForm form = new AddEditForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


            }
        }

        private void btnforgot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Enter username first");
                return;
            }

            ChangePassword form = new ChangePassword();

            form.Username = txtUser.Text;

            form.ShowDialog();
            
        }
    }

}
