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
    public partial class AddEditForm : Form
    {
        private int personId;
        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
        public AddEditForm()
        {
            InitializeComponent();
        }
        public AddEditForm(int UserId)
        {
            InitializeComponent();
            personId = UserId;
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT firstname, lastname, email, phonenumber, dateofbirth FROM persons WHERE UserId=@Id",
                    connection);

                cmd.Parameters.AddWithValue("@Id", personId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtFirstname.Text = reader["firstname"].ToString();
                    txtLastname.Text = reader["lastname"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtPhone.Text = reader["phonenumber"].ToString();
                    txtDob.Text = reader["dateofbirth"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"UPDATE persons 
                         SET firstname=@fn,
                             lastname=@ln,
                             email=@em,
                             phonenumber=@ph,
                             dateofbirth=@dob
                         WHERE UserId=@id";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@fn", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@ln", txtLastname.Text);
                cmd.Parameters.AddWithValue("@em", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ph", txtPhone.Text);
                cmd.Parameters.AddWithValue("@dob", txtDob.Text);
                cmd.Parameters.AddWithValue("@id", personId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Profile updated successfully");
            this.Close();
        }

     
    }
}
