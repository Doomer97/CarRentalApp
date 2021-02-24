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
    public partial class AddRentalRecord : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void fillCmboxCars()
        {
            try
            {
                /*Select * from typesOfCar
                List<TypesOfCars> cars = carRentalEntities.TypesOfCars.ToList();
                */
                var cars = carRentalEntities.TypesOfCars
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
                CarRentalRecord rentalRecord = new CarRentalRecord();
                rentalRecord.CustomerName = coustomerName;
                rentalRecord.DateRented = daterented;
                rentalRecord.DateReturned = datereturned;
                rentalRecord.Cost = (decimal)cost;
                rentalRecord.TypeOfCarID = (int)cmBox_TypeOfCar.SelectedValue;
                carRentalEntities.CarRentalRecord.Add(rentalRecord);
                carRentalEntities.SaveChanges(); 

                MessageBox.Show("Thank You for renting " + coustomerName,
               "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
