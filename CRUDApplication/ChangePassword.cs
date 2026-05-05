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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BCrypt.Net;




namespace Client_Management_System
{
    public partial class ChangePassword : Form
    {
        private string _username;
        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;

        public ChangePassword(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUser.Text = _username;
            txtUser.ReadOnly = true;
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNew.Text) || string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("Please fill both password fields");
                return;
            }

            if (txtNew.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = @"UPDATE LoginUser 
                           SET PasswordHash=@Pass 
                           WHERE Id=@UserId";

                SqlCommand updateCmd = new SqlCommand(updateQuery, connection);

                updateCmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value =
                    BCrypt.Net.BCrypt.HashPassword(txtNew.Text); 

                updateCmd.Parameters.Add("@UserId", SqlDbType.Int).Value =
                    Session.UserId; 

                int rows = updateCmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Password changed successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
        }
        
    }
}














