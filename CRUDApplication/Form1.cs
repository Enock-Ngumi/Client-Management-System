using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;
using System.Runtime.InteropServices.Marshalling;
using System.Linq.Expressions;
using System.Windows.Forms;
using Client_Management_System;
using System;
using System.Net.Http.Headers;


namespace CRUDApplication
{
    public partial class Form1 : Form
    {
        int selectedId = 0;
        DataTable table = new DataTable();

        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;




        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }
       
       
        private void ClearFields()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDob.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            UpdateButtonsState();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }
        private void UpdateButtonsState()
        {
            bool rowSelected = dataGridView1.CurrentRow != null;

            btnUpdate.Enabled = rowSelected;
            btnDelete.Enabled = rowSelected;
        }





        private void LoadData()
        {

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Firstname", typeof(string));
            table.Columns.Add("Lastname", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Phone", typeof(string));
            table.Columns.Add("Dateofbirth", typeof(string));

            dataGridView1.DataSource = table;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Persons", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Length == 0)
                    {
                        isAnyEmpty = true;
                        break;

                    }
                }
            }
            if (isAnyEmpty)
            {
                MessageBox.Show("please fill the required form", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = insertQuery = "INSERT INTO persons (firstname, lastname, email, phonenumber, dateofbirth) VALUES(@firstname, @lastname,@email, @phonenumber,@dateofbirth)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                            cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@phonenumber", txtPhone.Text);
                            cmd.Parameters.AddWithValue("@dateofbirth", txtDob.Text);

                            int count = cmd.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("Created Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }

        private void button3_Click(object sender, EventArgs e)

        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }

                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();



                        string readQuery = "SELECT * FROM persons";
                        SqlDataAdapter sda = new SqlDataAdapter(readQuery, connection);


                        SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }

                }

                catch (SqlException)
                {
                    MessageBox.Show("Problem Connecting to the Server", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(numericUpDown1.Value);
                string name = txtFirstname.Text;
                name = txtLastname.Text;
                name = txtEmail.Text;
                name = txtPhone.Text;
                name = txtDob.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE persons SET firstname=@firstname, lastname=@lastname, email=@email, phonenumber=@phone,dateofbirth=@dateofbirth Where id=@id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
                        cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                        cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@dateofbirth", txtDob.Text);


                        MessageBox.Show("ID being updated: " + numericUpDown1.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No Record Found to Update");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
            


            














































        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                ClearFields();
            }
            try
            {
                if (numericUpDown1.Value > 0)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM persons WHERE id=@id";
                        using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
                            int count = cmd.ExecuteNonQuery();
                            if (count > 0)
                            {
                                MessageBox.Show("Deleted Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            table.Rows.Add(selectedId++, txtFirstname.Text, txtLastname.Text, txtEmail.Text, txtPhone.Text, txtDob.Text);
            ClearFields();
            {
                AddEditForm frm = new AddEditForm();
                frm.ShowDialog();

                LoadData();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[1].Value = txtFirstname.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtLastname.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtEmail.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtPhone.Text;
                dataGridView1.CurrentRow.Cells[1].Value = txtDob.Text;

            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            AddEditForm frm = new AddEditForm(id);
            frm.ShowDialog();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Persons WHERE Id=@Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }

                LoadData();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    numericUpDown1.Value = Convert.ToDecimal(row.Cells["id"].Value);
                    txtFirstname.Text = row.Cells["firstname"].Value.ToString();
                    txtLastname.Text = row.Cells["lastname"].Value.ToString();
                    txtPhone.Text = row.Cells["phonenumber"].Value.ToString();
                    txtDob.Text = row.Cells["dateofbirth"].Value.ToString();
                    txtEmail.Text = row.Cells["email"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            {
                e.ThrowException = false;
                MessageBox.Show("Invalid data entered in Grid");
            }
        }
    }
}
    









