using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRentalEntities _db;
        public Login()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(txtBox_Username.Text) || string.IsNullOrEmpty(txtBox_Password.Text)))
                {
                    string username = txtBox_Username.Text.Trim();
                    string password = txtBox_Password.Text;
                    //Convert the input string to a byte array and compute the hash.

                    string hashed_password = Utils.HashPassword(password);

                    var user = _db.Users.FirstOrDefault(
                        q => q.username == username
                        && q.password == hashed_password
                        && q.isActive == true);

                    if (user == null)
                    {
                        MessageBox.Show("please provide valid credentials");
                    }
                    else
                    {
                        if (user.isActive == false)
                        {
                            MessageBox.Show("Sorry. This user is currently deactivated");
                        }
                        else
                        {
                            if (!Utils.FormIsOpen("MainWindow"))
                            {
                                UserRole role = user.UserRoles.FirstOrDefault();
                                var roleName = role.Role.shortname;
                                MainWindow mainWindow = new MainWindow(this, user);
                                this.Hide();
                                mainWindow.Show();
                            }
                        }//login success
                    }
                }//empty user or pass
                else
                {
                    MessageBox.Show("Username or password should not be empty", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
