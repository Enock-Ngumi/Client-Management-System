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

        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
        public static string LoggedInUsername;

        public Login()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter username and password");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM LoginUser WHERE Username=@User AND PasswordHash=@Pass";
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@Pass", password);

                object result = cmd.ExecuteScalar();
                int count = (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);

                if (count > 0)
                {

                    LoggedInUsername = username;

                    MessageBox.Show("Login successful");


                    AddEditForm form = new AddEditForm();
                    form.Show();
                    this.Hide();
                }
            
                else
                {
                    MessageBox.Show("Invalid username or password");
                }

            }
        }
        private void btnforgot_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();

            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Username is required");
                return;
            }

            ChangePassword form = new ChangePassword(user);
            form.Show();
            this.Hide();

        }
    }

}
        
    




    

            