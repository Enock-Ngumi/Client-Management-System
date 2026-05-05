using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using BCrypt.Net;

namespace Client_Management_System
{
    public partial class Mainform : Form
    {
        private int inactivityCounter = 0;
        private Permissions _permissions;
        private string _username;

        public Mainform(string username, Permissions permissions)
        {
            InitializeComponent();
            _username = username;
            _permissions = permissions;


            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            if (btnAdmin == null || btnUserManagement == null)
                return;

            bool isAdmin = _permissions.CanManageUsers;

            btnAdmin.Visible = isAdmin;
            btnUserManagement.Visible = isAdmin;

        }


        private void Mainform_Load(object sender, EventArgs e)
        {

            label1.Text = "Logged in as: " + _username;
        }

        private void btnUserManagement_Click_1(object sender, EventArgs e)
        {
            if (!_permissions.CanManageUsers)
            {
                MessageBox.Show("Access denied.");
                return;
            }
            
                Form1 f = new Form1(_permissions);
                f.Show();
                
            

                
        }

        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(_username);
            f.Show();
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            if (Session.Role != "Admin")
            {
                MessageBox.Show("Only admins can add users");
                return;
            }

            AdminDashboard f = new AdminDashboard();
            f.Show();


        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (Session.Role == "Admin")
            {
                AdminDashboard f = new AdminDashboard();
                f.Show();
            }
            else
            {
                MessageBox.Show("Access denied");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewClientsForm v = new ViewClientsForm(Session.Username);
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            Login f = new Login();
            f.Show();

            this.Close();
        }

        private void inactivityTimer_Tick(object sender, EventArgs e)
        {
            inactivityCounter++;

            if (inactivityCounter >= 5)
            {
                MessageBox.Show("Session expired due to inactivity.");

                Login f = new Login();
                f.Show();

                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }

}

    

