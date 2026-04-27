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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM LoginUser WHERE Username=@User AND passwordHash=@Pass";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@User", username);
                command.Parameters.AddWithValue("@Pass", password);
               
                connection.Open();

                int count = (int)command.ExecuteScalar();

                if (count >0)
                {
                    AddEditForm form = new AddEditForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login");
                }

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
