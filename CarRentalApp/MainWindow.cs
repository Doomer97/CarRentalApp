using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _RoleName;
        public User _user;
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login, User user)
        {
            InitializeComponent();
            _login = login;
            _user = user;
            _RoleName = _user.UserRoles.FirstOrDefault().Role.shortname;
        }
        

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditRentalRecord"))
            {
                AddEditRentalRecord addRentalRecord = new AddEditRentalRecord();
                addRentalRecord.MdiParent = this;
                addRentalRecord.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(_user.password== Utils.DefaultHashPassword())
            {
                ResetPassword resetPassword = new ResetPassword(_user,this);
                resetPassword.ShowDialog();
            }
            tSStrip_UserStat.Text = $"Logged In as: {_user.username}";
            if (_RoleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageVehicleListing"))
            {
                ManageVehicleListing vechicleListing = new ManageVehicleListing();
                vechicleListing.MdiParent = this;
                vechicleListing.Show();
            }
        }

        private void manageRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            if (!Utils.FormIsOpen("ManageRentalRecords"))
            { 
                ManageRentalRecords manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers"))
            { 
                ManageUsers manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.Show(); 
            }
        }
    }
}
