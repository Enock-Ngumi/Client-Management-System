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
    public partial class ViewClientsForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
        public ViewClientsForm()
        {
            InitializeComponent();
        }
        private void LoadClients()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT Id, firstname, lastname, email, phonenumber, dateofbirth FROM persons";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewClients.DataSource = dt;
            }
        }


        private void ViewClientsForm_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT Id, firstname, lastname, email, phonenumber, dateofbirth
                         FROM persons
                         WHERE firstname LIKE @Search
                            OR lastname LIKE @Search
                            OR phonenumber LIKE @Search";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewClients.DataSource = dt;
            }
        }
    }
}
