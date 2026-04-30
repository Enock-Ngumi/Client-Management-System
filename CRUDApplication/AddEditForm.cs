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
        int personId = 0;
        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
        public AddEditForm()
        {
            InitializeComponent();
        }
        public AddEditForm(int id)
        {
            InitializeComponent();
            personId = id;
        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {
            if (personId > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM persons WHERE Id=@Id", connection);
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd;

                if (personId == 0)
                {
                    cmd = new SqlCommand(
                        "INSERT INTO persons (firstname, lastname, email, phonenumber, dateofbirth) VALUES (@firstname, @lastname, @email, @phonenumber, @dateofbirth)",
                        connection);
                }
                else
                {
                    cmd = new SqlCommand(
                        "UPDATE persons SET firstname=@firstname, lastname=@lastname, email=@email, phonenumber=@phonenumber, dateofbirth=@dateofbirth WHERE id=@id",
                    connection);
                    cmd.Parameters.AddWithValue("@Id", personId);
                }

                cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phonenumber", txtPhone.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", txtDob.Text);


                cmd.ExecuteNonQuery();
            }

            this.Close();
        }
    }
}
