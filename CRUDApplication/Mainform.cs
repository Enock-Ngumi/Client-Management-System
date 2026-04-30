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

namespace Client_Management_System
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

            label1.Text = "Logged in as: " + Session.CurrentUser;
        }

        private void btnUserManagement_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(Session.CurrentUser);
            f.Show();
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            AddEditForm f = new AddEditForm();
            f.Show();
        }
    }

}
    

