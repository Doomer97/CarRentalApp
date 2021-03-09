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
    public partial class ResetPassword : Form
    {
        private readonly CarRentalEntities _db;
        private User _user;
        private MainWindow _mainWindow;
        bool passwordChanged=false;
        public ResetPassword(User user,MainWindow mainWindow)
        {
            InitializeComponent();
            _user=user;
            _db = new CarRentalEntities();
            _mainWindow = mainWindow;
        }

        private void btn_ResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                var pass1 = txtBox_Pass1.Text;
                var pass2 = txtBox_Pass2.Text;
                var user = _db.Users.FirstOrDefault(q => q.id == _user.id);
                if (pass1 != pass2)
                {
                    MessageBox.Show("Password do not match. Please try again");
                }
                else
                {
                    user.password = Utils.HashPassword(pass1);
                    _db.SaveChanges();
                    passwordChanged = true;
                    MessageBox.Show("Reset Succssesfully");
                    Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
