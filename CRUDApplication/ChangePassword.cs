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
    public partial class ChangePassword : Form
    {
        
        
        public string Username { get; set; }
        
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            string newPassword = txtNew.Text;
            string confirmPassword = txtConfirm.Text;

            if(newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            

            string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                

                SqlCommand cmd = new SqlCommand("UPDATE dbo.persons SET Password=@Pass WHERE Username=@User", connection);

                cmd.Parameters.AddWithValue("@Pass", txtNew.Text);
                cmd.Parameters.AddWithValue("@User", Username);
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Password Changed successfully");
                        

                    }
                    else
                    {
                        MessageBox.Show("User not found");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }





            }
        }
    }
}

            
    



