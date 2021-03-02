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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentalEntities _db;

        public AddEditVehicle(ManageVehicleListing manageVehicleListing=null)
        {
            InitializeComponent();
            lbl_Title.Text = "Add New Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities();
        }
        public AddEditVehicle(TypesOfCars carToEdit, ManageVehicleListing manageVehicleListing=null)
        {
            InitializeComponent();
            lbl_Title.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";
            _manageVehicleListing = manageVehicleListing;
            if (carToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(carToEdit);
            }
        }

        private void PopulateFields(TypesOfCars car)
        {
            lbl_Id.Text = car.Id.ToString();
            txtBox_Name.Text = car.Make;
            txtBox_Model.Text = car.Model;
            txtBox_VIN.Text = car.VIN;  
            txtBox_Year.Text = car.Year.ToString();
            txtBox_LicensePlate.Text = car.LicensePlateNumber;
        }

        private void AddEditVehicle_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string result;
            try
            {
                if (isEditMode)
                {
                    int id = int.Parse(lbl_Id.Text);
                    var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                    car.Make = txtBox_Name.Text;
                    car.Model = txtBox_Model.Text;
                    car.VIN = txtBox_VIN.Text;
                    car.Year = int.Parse(txtBox_Year.Text);
                    car.LicensePlateNumber = txtBox_LicensePlate.Text;

                    _db.SaveChanges();
                    result = "Edid Success";
                }
                else
                {
                    var newCar = new TypesOfCars
                    {
                        Make = txtBox_Name.Text,
                        Model = txtBox_Model.Text,
                        VIN = txtBox_VIN.Text,
                        Year = int.Parse(txtBox_Year.Text),
                        LicensePlateNumber = txtBox_LicensePlate.Text
                    };
                    _db.TypesOfCars.Add(newCar);
                    _db.SaveChanges();
                    result = "Add Success";
                }
                _manageVehicleListing.populateData();
                MessageBox.Show(result);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please check all the fields");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
