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
                string username = txtBox_Username.Text.Trim();
                string password = txtBox_Password.Text;
                //Convert the input string to a byte array and compute the hash.
                SHA256 sha = SHA256.Create();
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                //Create Stringbuilder to collect bytes and create a string
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }
                var hashed_password = stringBuilder.ToString();

                var user = _db.Users.FirstOrDefault(q => q.username == username && q.password == hashed_password);
                if (user == null)
                {
                    MessageBox.Show("please provide valid credentials");
                }
                else
                {
                    var OpenForms = Application.OpenForms.Cast<Form>();
                    bool isOpen = OpenForms.Any(q => q.Name == "MainWindow");
                    if (!isOpen)
                    {
                        MainWindow mainWindow = new MainWindow(this);
                        this.Hide();
                        mainWindow.Show();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Please try again");
            }
        }
    }
}
