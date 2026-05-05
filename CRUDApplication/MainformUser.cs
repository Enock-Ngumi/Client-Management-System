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
using BCrypt.Net;

namespace Client_Management_System
{
    public partial class MainformUser : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;
        private string _username;
        private Permissions _permissions;

        public MainformUser(string username, Permissions permissions)
        {
            InitializeComponent();

            _username = username;
            _permissions = permissions;

            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            if (_permissions == null) return;

            if (list != null)
                list.Visible = _permissions.CanViewClients;

            if (btnAddUser != null)
                btnAddUser.Visible = false;

            if (btnEditUser != null)
                btnEditUser.Visible = false;
        }


        private void LoadForm(Form form)
        {
            panelcontainer.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            panelcontainer.Controls.Add(form);
            form.Show();
        }
        private void MainformUser_Load(object sender, EventArgs e)
        {

            label1.Text = "Logged in as: " + _username;

        }

        private void list_Click(object sender, EventArgs e)
        {
            LoadForm(new AddEditForm(Session.UserId));
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        private void panelcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm f = new UserProfileForm(Session.Username);
            f.Show();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            LoadForm(new ChangePassword(_username));
        }

        private void LogOut_Click(object sender, EventArgs e)
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
    }

}
