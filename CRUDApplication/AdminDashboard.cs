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
    public partial class AdminDashboard : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();
            string role = chkIsAdmin.Checked ? "Admin" : "User";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string checkQuery = @"SELECT COUNT(*) 
                              FROM LoginUser 
                              WHERE LOWER(Username) = @User";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@User", username);

                int exists = (int)checkCmd.ExecuteScalar();

                if (exists > 0)
                {
                    MessageBox.Show("Username already exists");
                    return;
                }

                string query = @"INSERT INTO LoginUser 
                         (Username, PasswordHash, Role, FailedAttempts, IsLocked)
                         VALUES (@User, @Pass, @Role, 0, 0)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@User", username);
                cmd.Parameters.AddWithValue("@Pass", PasswordHelper.HashPassword(password));
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.ExecuteNonQuery();
                LoadData();

                MessageBox.Show("User created successfully!");

                txtUsername.Clear();
                txtPassword.Clear();
                chkIsAdmin.Checked = false;
            }
        }

        private void Unlockusername_Click(object sender, EventArgs e)
        {

        }

        private void btnUnlockUser_Click(object sender, EventArgs e)
        {

            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first");
                return;
            }

            string username = dataGridViewUsers.SelectedRows[0].Cells["Username"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Invalid selection");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"UPDATE LoginUser
                         SET FailedAttempts = 0,
                             IsLocked = 0
                         WHERE Username = @User";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@User", username);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User unlocked successfully");

            LoadLockedUsers();
        }
        private void LoadLockedUsers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT Username, Role, FailedAttempts, IsLocked
                         FROM LoginUser";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewUsers.DataSource = dt;
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadLockedUsers();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadLockedUsers();
        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT Username, Role, FailedAttempts, IsLocked
                         FROM LoginUser";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridViewUsers.DataSource = dt;
            }
        }

    }
}
