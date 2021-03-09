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

    public partial class AddUser : Form
    {
        private ManageUsers _manageUsers;
        private readonly CarRentalEntities _db;
        public AddUser(ManageUsers manageUsers=null)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            if (manageUsers != null)
                _manageUsers = manageUsers;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.Roles.ToList();
            cmBox_Roles.DataSource = roles;
            cmBox_Roles.ValueMember = "id";
            cmBox_Roles.DisplayMember = "name";

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            _manageUsers.populateDatag();
            Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtBox_Username.Text;
                int roleId = (int)cmBox_Roles.SelectedValue;
                string password = Utils.DefaultHashPassword();
                User user = new User
                {
                    username = username,
                    password = password,
                    isActive = true
                };
                _db.Users.Add(user);
                _db.SaveChanges();

                int userid = user.id;
                var userRole = new UserRole
                {
                    roleid = roleId,
                    userid = userid
                };
                _db.UserRoles.Add(userRole);
                _db.SaveChanges();
                MessageBox.Show("New user added succssesfully");
                _manageUsers.populateDatag();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message}");
            }
        }
    }
}
