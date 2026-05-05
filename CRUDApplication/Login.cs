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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Client_Management_System
{
    public partial class Login : Form
    {

        string connectionString =
            ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {

            string usernameInput = txtUser.Text.Trim();
            string passwordInput = txtPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(usernameInput) || string.IsNullOrWhiteSpace(passwordInput))
            {
                MessageBox.Show("Enter username and password");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT Id, Username, PasswordHash, Role, FailedAttempts, IsLocked 
                     FROM LoginUser 
                     WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", usernameInput);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("User not found");
                            return;
                        }

                        int userId = (int)reader["Id"];
                        string username = reader["Username"].ToString();
                        string hashedPassword = reader["PasswordHash"].ToString();
                        string role = reader["Role"].ToString();

                        int failedAttempts = Convert.ToInt32(reader["FailedAttempts"]);
                        bool isLocked = Convert.ToBoolean(reader["IsLocked"]);

                        reader.Close();

                        if (isLocked)
                        {
                            MessageBox.Show("Account is locked. Contact admin.");
                            return;
                        }

                        bool isValid = BCrypt.Net.BCrypt.Verify(passwordInput, hashedPassword);

                        if (!isValid)
                        {
                            failedAttempts++;

                            if (failedAttempts >= 3)
                            {
                                string lockQuery = @"UPDATE LoginUser 
                                         SET FailedAttempts = @fa, IsLocked = 1 
                                         WHERE Id = @id";

                                SqlCommand lockCmd = new SqlCommand(lockQuery, con);
                                lockCmd.Parameters.AddWithValue("@fa", failedAttempts);
                                lockCmd.Parameters.AddWithValue("@id", userId);
                                lockCmd.ExecuteNonQuery();

                                MessageBox.Show("Account locked due to too many failed attempts.");
                                return;
                            }

                            string failQuery = @"UPDATE LoginUser 
                                     SET FailedAttempts = @fa 
                                     WHERE Id = @id";

                            SqlCommand failCmd = new SqlCommand(failQuery, con);
                            failCmd.Parameters.AddWithValue("@fa", failedAttempts);
                            failCmd.Parameters.AddWithValue("@id", userId);
                            failCmd.ExecuteNonQuery();

                            MessageBox.Show($"Invalid password. Attempts: {failedAttempts}/3");
                            return;
                        }

                        string resetQuery = @"UPDATE LoginUser 
                                  SET FailedAttempts = 0 
                                  WHERE Id = @id";

                        SqlCommand resetCmd = new SqlCommand(resetQuery, con);
                        resetCmd.Parameters.AddWithValue("@id", userId);
                        resetCmd.ExecuteNonQuery();

                        Session.UserId = userId;
                        Session.Username = username;
                        Session.Role = role;

                        Permissions permissions = new Permissions
                        {
                            CanViewClients = true,
                            CanManageUsers = (role == "Admin"),
                            CanAddUsers = (role == "Admin"),
                            CanEditUsers = (role == "Admin"),
                            CanDeleteUsers = (role == "Admin"),
                        };

                        MessageBox.Show("Login successful!");

                        this.Hide();

                        if (role == "Admin")
                            new Mainform(username, permissions).Show();
                        else
                            new MainformUser(username, permissions).Show();
                    }
                }
            }
        }
        private void btnforgot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Username is required");
                return;
            }

            new ChangePassword(txtUser.Text.Trim()).Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SavedUsername))
            {
                txtUser.Text = Properties.Settings.Default.SavedUsername;
                chkRememberMe.Checked = true;
            }

            txtPass.UseSystemPasswordChar = true;
            txtUser.Text = Properties.Settings.Default.SavedUsername;
            txtPass.Clear();
            txtUser.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.SavedUsername = txtUser.Text;
            }
            else
            {
                Properties.Settings.Default.SavedUsername = "";
            }

            Properties.Settings.Default.Save();
        }
    }

}





