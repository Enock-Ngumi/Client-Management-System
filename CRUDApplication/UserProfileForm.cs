using System;
using System.Collections;
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
    public partial class UserProfileForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
        private string _username;

        public UserProfileForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void LoadUserData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT p.firstname, p.lastname, p.email, p.phonenumber, p.dateofbirth
                         FROM persons p
                         INNER JOIN LoginUser u ON p.UserId = u.Id
                         WHERE u.Username = @User";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@User", _username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["firstname"]?.ToString();
                            txtLastName.Text = reader["lastname"]?.ToString();
                            txtEmail.Text = reader["email"]?.ToString();
                            txtPhone.Text = reader["phonenumber"]?.ToString();
                            txtDob.Text = reader["dateofbirth"]?.ToString();

                            reader.Close();
                        }
                    }
                }
            }
        }
        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void firstname_Click(object sender, EventArgs e)
        {

        }
    }
}
