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
using BCrypt.Net;

namespace Client_Management_System
{
    public partial class RegisterForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;

        private bool _isAdmin;

        public RegisterForm(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }
        public RegisterForm()
        {
            InitializeComponent();
            _isAdmin = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            string role;

            if (_isAdmin)
            {
                role = chkIsAdmin.Checked ? "Admin" : "User";
            }
            else
            {
                role = "User";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM LoginUser WHERE Username = @User";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@User", username);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("Username already exists");
                        return;
                    }

                    string insertUser = @"INSERT INTO LoginUser (Username, PasswordHash, Role)
                              OUTPUT INSERTED.Id
                              VALUES (@User, @Pass, @Role)";

                    SqlCommand cmdUser = new SqlCommand(insertUser, con);
                    cmdUser.Parameters.AddWithValue("@User", username);
                    cmdUser.Parameters.AddWithValue("@Pass", PasswordHelper.HashPassword(password));
                    cmdUser.Parameters.AddWithValue("@Role", role);

                    int userId = (int)cmdUser.ExecuteScalar();

                    string insertPerson = @"INSERT INTO persons 
                               (UserId, firstname, lastname, email, phonenumber, dateofbirth)
                               VALUES (@UserId, @fn, @ln, @em, @ph, @db)";

                    SqlCommand cmdPerson = new SqlCommand(insertPerson, con);
                    cmdPerson.Parameters.AddWithValue("@UserId", userId);
                    cmdPerson.Parameters.AddWithValue("@fn", txtFirstName.Text);
                    cmdPerson.Parameters.AddWithValue("@ln", txtLastName.Text);
                    cmdPerson.Parameters.AddWithValue("@em", txtEmail.Text);
                    cmdPerson.Parameters.AddWithValue("@ph", txtPhone.Text);
                    cmdPerson.Parameters.AddWithValue("@db", txtDob.Text);

                    cmdPerson.ExecuteNonQuery();

                    MessageBox.Show("User registered successfully!");
                    this.Close();
                }
            }
        }
        

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            chkIsAdmin.Enabled = _isAdmin;
            chkIsAdmin.Checked = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
