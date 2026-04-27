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

        public ChangePassword()
        {
            InitializeComponent();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {

            txtUser.Text = _username;
            txtUser.ReadOnly = true;
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            string user = _username;
            string Newpass = txtNew.Text.Trim();
            string Confirmpass = txtConfirm.Text.Trim();

            if (string.IsNullOrWhiteSpace(Newpass) || string.IsNullOrWhiteSpace(Confirmpass))
            {
                MessageBox.Show("Please fill both password fields");
                return;
            }

            if (!Newpass.Equals(Confirmpass))
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (string.IsNullOrEmpty(Newpass))
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM LoginUser WHERE Username=@User";
                SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@User", user);

                object result = checkCmd.ExecuteScalar();
                int exists = (result == null || result == DBNull.Value) ? 0 : Convert.ToInt32(result);

                if (exists == 0)
                {
                    MessageBox.Show("User not found");
                    return;
                }

                string updateQuery = "UPDATE LoginUser SET PasswordHash=@Pass WHERE Username=@User";
                SqlCommand updateCmd = new SqlCommand(updateQuery, connection);

                updateCmd.Parameters.AddWithValue("@Pass", Newpass);
                updateCmd.Parameters.AddWithValue("@User", user);

                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Password changed successfully");
                this.Close();
                

                Login login = new Login();
                login.Show();
                this.Close();


            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
            
            


    }     
}













