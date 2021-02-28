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
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        public AddEditRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            label1.Text = "Add New Rental Record";
            this.Text = "Add New Rental";
            isEditMode = false;
        }
        public AddEditRentalRecord(CarRentalRecord recordToEdit)
        {
            InitializeComponent();
            label1.Text = "Edit Vehicle";
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            txtBox_CoustomerName.Text = recordToEdit.CustomerName;
            //cmBox_TypeOfCar.Text=recordToEdit.TypeOfCarID
            dateRented.Value = (DateTime)recordToEdit.DateRented;
            dateReturned.Value = (DateTime)recordToEdit.DateReturned;
            txtBox_Cost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
        }

        private void fillCmboxCars()
        {
            try
            {
                /*Select * from typesOfCar
                List<TypesOfCars> cars = _db.TypesOfCars.ToList();
                */
                var cars = _db.TypesOfCars
                    .Select(q => new { Id = q.Id, Name = (q.Make + " " + q.Model)}).ToList();
                cmBox_TypeOfCar.DisplayMember = "Name";
                cmBox_TypeOfCar.ValueMember = "Id";
                cmBox_TypeOfCar.DataSource = cars;
            }
            catch (Exception)
            {
                while (MessageBox.Show("We could not establish a connection with the database",
                                    "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                                    == System.Windows.Forms.DialogResult.Retry)
                {
                    fillCmboxCars();
                    return;
                }
                cmBox_TypeOfCar.Enabled = false;
            }

        }

        private double toDouble(string value)
        {
            try {return Convert.ToDouble(value);}
            catch(Exception){return -1.0;}
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string coustomerName = txtBox_CoustomerName.Text;
            string cartype = cmBox_TypeOfCar.Text;
            DateTime daterented = dateRented.Value;
            DateTime datereturned = dateReturned.Value;
            double cost =toDouble(txtBox_Cost.Text);
            bool isValid=true;
            string errorMessage="";

            if (string.IsNullOrWhiteSpace(coustomerName)||string.IsNullOrWhiteSpace(cartype))
            {
                isValid = false;
                errorMessage+="Error: Please enter the missing data.\n\r";
            }
            if (daterented>datereturned)
            {
                isValid = false;
                errorMessage+="Error: Illegal Date Selection\n\r";
            }
            if (isValid)
            {
                var rentalRecord = new CarRentalRecord();
                if (isEditMode)
                {
                    var id = int.Parse(lblRecordId.Text);
                    rentalRecord = _db.CarRentalRecord.FirstOrDefault(q => q.id == id);
                }
                rentalRecord.CustomerName = coustomerName;
                rentalRecord.DateRented = daterented;
                rentalRecord.DateReturned = datereturned;
                rentalRecord.Cost = (decimal)cost;
                rentalRecord.TypeOfCarID = (int)cmBox_TypeOfCar.SelectedValue;

                if(!isEditMode)
                    _db.CarRentalRecord.Add(rentalRecord);

                _db.SaveChanges();

                MessageBox.Show("Thank You for renting " + coustomerName,
               "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }

            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCmboxCars();
        }
    }
}
