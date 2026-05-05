using Client_Management_System;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Windows.Forms;
using System.Xml.Linq;
using BCrypt.Net;

namespace Client_Management_System
{
    public partial class Form1 : Form
    {
        private Permissions _permissions;

        string connectionString =
            ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;

        public Form1(Permissions permissions)
        {
            InitializeComponent();
            _permissions = permissions;

            ApplyPermissions();
        }
        private void ApplyPermissions()
        {
            dataGridView1.ReadOnly = !_permissions.CanEditUsers;

            btnCreate.Enabled = _permissions.CanAddUsers;
            btnUpdating.Enabled = _permissions.CanEditUsers;
            Delete.Enabled = _permissions.CanDeleteUsers;

            Add.Enabled = _permissions.CanAddUsers;
            Update.Enabled = _permissions.CanEditUsers;
            btnDelete.Enabled = _permissions.CanDeleteUsers;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadData();

            dataGridView1.Visible = false;

            ClearFields();
            numericUpDown1.Value = 0;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM persons", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(txtFirstname.Text)
                && !string.IsNullOrWhiteSpace(txtLastname.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtPhone.Text);
        }
        private void ClearFields()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDob.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
            numericUpDown1.Value = 0;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            txtFirstname.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!_permissions.CanAddUsers)
            {
                MessageBox.Show("Access denied.");
                return;
            }

            if (!IsValid())
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"INSERT INTO persons 
                        (firstname, lastname, email, phonenumber, dateofbirth)
                        VALUES (@fn, @ln, @em, @ph, @dob)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fn", txtFirstname.Text.Trim());
                    cmd.Parameters.AddWithValue("@ln", txtLastname.Text.Trim());
                    cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", txtDob.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User created successfully!");
            LoadData();
            ClearFields();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = !dataGridView1.Visible;

            if (dataGridView1.Visible)
            {
                LoadData();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (!_permissions.CanEditUsers)
            {
                MessageBox.Show("Access denied.");
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a record first.");
                return;
            }

            if (!IsValid())
            {
                MessageBox.Show("Fill all required fields.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"UPDATE persons 
                         SET firstname=@fn,
                             lastname=@ln,
                             email=@em,
                             phonenumber=@ph,
                             dateofbirth=@dob
                         WHERE Id=@id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fn", txtFirstname.Text.Trim());
                    cmd.Parameters.AddWithValue("@ln", txtLastname.Text.Trim());
                    cmd.Parameters.AddWithValue("@em", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", txtDob.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Updated successfully!");
            LoadData();
            ClearFields();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!_permissions.CanDeleteUsers)
            {
                MessageBox.Show("Access denied.");
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a record first.");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "DELETE FROM persons WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            numericUpDown1.Value = Convert.ToDecimal(row.Cells["id"].Value);
            txtFirstname.Text = row.Cells["firstname"].Value?.ToString();
            txtLastname.Text = row.Cells["lastname"].Value?.ToString();
            txtEmail.Text = row.Cells["email"].Value?.ToString();
            txtPhone.Text = row.Cells["phonenumber"].Value?.ToString();
            txtDob.Text = row.Cells["dateofbirth"].Value?.ToString();
        }
        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            MessageBox.Show("Invalid data in grid.");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
