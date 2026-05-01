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

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter username and password");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT Username, PasswordHash, Role, FailedAttempts, IsLocked
                         FROM LoginUser
                         WHERE Username = @User";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@User", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("User not found");
                            return;
                        }

                        string dbPassword = reader["PasswordHash"].ToString();
                        string role = reader["Role"].ToString();
                        int failedAttempts = Convert.ToInt32(reader["FailedAttempts"]);
                        bool isLocked = Convert.ToBoolean(reader["IsLocked"]);

                        if (isLocked)
                        {
                            MessageBox.Show("Account is locked. Contact admin.");
                            return;
                        }

                        if (!PasswordHelper.VerifyPassword(password, dbPassword))
                        {
                            reader.Close();
                            IncreaseFailedAttempts(username, failedAttempts);

                            int newAttempts = failedAttempts + 1;

                            if (newAttempts >= 3)
                                MessageBox.Show("Account locked after 3 failed attempts. Contact admin.");
                            else
                                MessageBox.Show($"Incorrect password. Attempts left: {3 - newAttempts}");

                            return;
                        }

                        reader.Close();

                        ResetFailedAttempts(username);

                        Session.Username = username;
                        Session.Role = role;

                        Permissions permissions = new Permissions();

                        if ((role ?? "").Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        {
                            permissions.CanViewAdmin = true;
                            permissions.CanViewClients = true;
                            permissions.CanManageUsers = true;


                        }
                        else
                        {
                            permissions.CanViewAdmin = false;
                            permissions.CanViewClients = false;
                            permissions.CanManageUsers = false;

                        } 
                        

                        DialogResult result = MessageBox.Show("Login successful!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            this.Hide();

                            if (role == "Admin")
                            {
                                new Mainform(username, permissions).Show();
                            }
                            else
                            {
                                new MainformUser(username, permissions).Show();
                            }
                        }
                        Properties.Settings.Default.SavedUsername =
                            chkRememberMe.Checked ? username : "";
                        Properties.Settings.Default.Save();
                    }
                }
            }
        }
        private void ResetFailedAttempts(string username)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"UPDATE LoginUser
                         SET FailedAttempts = 0
                         WHERE Username = @User";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@User", username);
                cmd.ExecuteNonQuery();
            }
        }

        private void IncreaseFailedAttempts(string username, int currentAttempts)
        {
            currentAttempts++;


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query;

                if (currentAttempts >= 3)
                {
                    query = @"UPDATE LoginUser
                      SET FailedAttempts = @Attempts,
                          IsLocked = 1
                      WHERE Username = @User";
                }
                else
                {
                    query = @"UPDATE LoginUser
                      SET FailedAttempts = @Attempts
                      WHERE Username = @User";
                }

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Attempts", currentAttempts);
                cmd.Parameters.AddWithValue("@User", username);
                cmd.ExecuteNonQuery();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {

            RegisterForm f = new RegisterForm();
            f.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            txtPass.UseSystemPasswordChar = true;
            txtUser.Text = Properties.Settings.Default.SavedUsername;
            txtPass.Focus();

            txtUser.Text = Session.Username;
            txtPass.Clear();

            txtUser.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void picEye_Click(object sender, EventArgs e)
        {

        }
    }

}
    


    


        


                        
    
    

        
    
            
        
    









            