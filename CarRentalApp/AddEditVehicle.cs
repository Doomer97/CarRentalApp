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
        private readonly CarRentalEntities _db;
        public AddEditVehicle()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            lbl_Title.Text = "Add New Vehicle";
            isEditMode = false;
        }
        public AddEditVehicle(TypesOfCars carToEdit)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            lbl_Title.Text = "Edit Vehicle";
            isEditMode = true;
            PopulateFields(carToEdit);
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
            if (isEditMode)
            {
                int id = int.Parse(lbl_Id.Text);
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                car.Make = txtBox_Name.Text;
                car.Model = txtBox_Model.Text;
                car.VIN = txtBox_VIN.Text;
                car.Year=int.Parse(txtBox_Year.Text);
                car.LicensePlateNumber = txtBox_LicensePlate.Text;

                _db.SaveChanges();
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
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
