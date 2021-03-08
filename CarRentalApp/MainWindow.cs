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
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Login login)
        {
            InitializeComponent();
            _login = login;
        }
        

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(q => q.Name == "AddEditRentalRecord");
            if (!isOpen)
            {
                AddEditRentalRecord addRentalRecord = new AddEditRentalRecord();
                addRentalRecord.MdiParent = this;
                addRentalRecord.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(q => q.Name == "ManageVehicleListing");
            if (!isOpen)
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
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(q => q.Name == "ManageRentalRecords");
            if (!isOpen)
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
    }
}
