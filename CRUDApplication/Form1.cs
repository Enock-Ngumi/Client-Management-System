using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace CRUDApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
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
                SqlConnection con = new SqlConnection("Data Source=NGUMI\\SQLEXPRESS;Initial Catalog=persons;Integrated Security=True");
                con.Open();
                string insertQuery = "INSERT INTO persons (firstname, lastname, email, phonenumber, dateofbirth) VALUES (@firstname, @lastname, @email, @phonenumber, @dateofbirth)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phonenumber", txtPhone.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", txtDob.Text);
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Created successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


                SqlConnection con = new SqlConnection("Data Source=NGUMI\\SQLEXPRESS;Initial Catalog=persons;Integrated Security=True");
                string readQuery = "SELECT * FROM persons";
                SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
                SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

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
            SqlConnection con = new SqlConnection("Data Source=NGUMI\\SQLEXPRESS;Initial Catalog=persons;Integrated Security=True");
            con.Open();
            string updateQuery = "UPDATE persons SET firstname=@firstname, lastname=@lastname, email=@email, phonenumber=@phonenumber, dateofbirth=@dateofbirth WHERE id=@id";
            SqlCommand cmd = new SqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phonenumber", txtPhone.Text);
            cmd.Parameters.AddWithValue("@dateofbirth", txtDob.Text);
            cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Updated Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NGUMI\\SQLEXPRESS;Initial Catalog=persons;Integrated Security=True");
            con.Open();
            string deleteQuery = "DELETE FROM persons WHERE id=@id";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
            int count = cmd.ExecuteNonQuery();
            if(count > 0)
            {
                MessageBox.Show("Deleted Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
                
 


