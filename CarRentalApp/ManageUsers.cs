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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        public void populateDatag()
        {
            var users = _db.Users
                .Select(q => new
                {
                    q.id,
                    Username=q.username,
                    Role=q.UserRoles.FirstOrDefault().Role.name,
                    Active=q.isActive
                }).ToList();
            dGV_UserList.DataSource = users;
            dGV_UserList.Columns["id"].Visible = false;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populateDatag();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser(this);
                addUser.MdiParent=this.MdiParent;
                addUser.Show();
            }
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            try
            {

                // get id
                //We expect Int here (data type from database column). otherwise use var./ need casting
                int id = (int)dGV_UserList.SelectedRows[0].Cells["id"].Value;
                //query
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                var hashed_password = Utils.DefaultHashPassword();
                user.password = hashed_password;
                _db.SaveChanges();
                MessageBox.Show($"Password of user {user.username} have been resert");
                populateDatag();

            }
            catch (Exception)
            {
                MessageBox.Show("You Have to select a whole row in order to edit", "Error");
            }
        }

        private void btn_DeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                // get id
                //We expect Int here (data type from database column). otherwise use var./ need casting
                int id = (int)dGV_UserList.SelectedRows[0].Cells["id"].Value;
                //query
                var user = _db.Users.FirstOrDefault(q => q.id == id);
                user.isActive = user.isActive == true ? false : true; ;
                string status;

                _db.SaveChanges();
                if (user.isActive)
                    status = $"User {user.username} Activated";
                else
                    status = $"User {user.username} Deactivated";
                MessageBox.Show(status, "Info");
                populateDatag();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dGV_UserList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int id = (int)dGV_UserList.SelectedRows[0].Cells["id"].Value;
            //query
            //var user = _db.Users.FirstOrDefault(q => q.id == id);
            bool isActive=(bool)dGV_UserList.SelectedRows[0].Cells["Active"].Value;

            btn_DeactivateUser.Text= "Deactivate User";
            if (!isActive)
                btn_DeactivateUser.Text = "Activate User";
        }
    }
}
