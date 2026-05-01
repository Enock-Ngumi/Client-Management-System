using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Management_System
{
    public partial class MainformUser : Form
    {
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
            if (_permissions == null)
            {
                MessageBox.Show("Permissions not loaded");
                return;
            }

            list.Visible = _permissions.CanViewClients;

            btnAddUser.Visible = false;
            btnEditUser.Visible = false;

            btnAddUser.BringToFront();
            btnEditUser.BringToFront();
            list.BringToFront();
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
            LoadForm(new ViewClientsForm());
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
            LoadForm(new UserProfileForm(_username));
        }
    }

}
