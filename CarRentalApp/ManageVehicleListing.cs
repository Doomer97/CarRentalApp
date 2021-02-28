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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        private void populateData()
        {
            try
            {
                var cars = _db.TypesOfCars
                    .Select
                    (q => new
                    {
                        q.Make,
                        Model = q.Model,
                        VIN = q.VIN,
                        Year = q.Year,
                        LicensePlateNumber = q.LicensePlateNumber,
                        Id = q.Id
                    }).ToList();
                dGV_VehicleList.DataSource = cars;
                //allos tropos gia onoma
                dGV_VehicleList.Columns[4].HeaderText = "License Plate Number";
                dGV_VehicleList.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection with database could not be established");
                //disable controls TODO
            }
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //select * 
            //List<TypesOfCars> cars = _db.TypesOfCars.ToList();
            // dGV_VehicleList.Columns[0].HeaderText = "ID";
            // dGV_VehicleList.Columns[1].HeaderText = "NAME";


            //lamda query

            /*select id as CarID,name as Carname
            var cars => List<'a "anon type" > cars
            var cars = _db.TypesOfCars.Select
                (q => new { CarID = q.Id, Carname = q.Make }).ToList();
            dGV_VehicleList.DataSource = cars;
            */

            /*try
            {
                var cars = _db.TypesOfCars
                    .Select
                    (q => new
                    {
                        q.Make,
                        Model = q.Model,
                        VIN = q.VIN,
                        Year = q.Year,
                        LicensePlateNumber = q.LicensePlateNumber,
                        Id = q.Id
                    }).ToList();
                dGV_VehicleList.DataSource = cars;
                //allos tropos gia onoma
                dGV_VehicleList.Columns[4].HeaderText = "License Plate Number";
                dGV_VehicleList.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection with database could not be established");
                //disable controls
            }
            */
            populateData();
        }

       

        private void dGV_VehicleList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AddCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btn_EditCar_Click(object sender, EventArgs e)
        {
            try
            {
                // get id
                //We expect Int here (data type from database column). otherwise use var./ need casting
                int id = (int)dGV_VehicleList.SelectedRows[0].Cells["Id"].Value;
                //query
                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);

                // launch addeditvehicle window with data
                AddEditVehicle addEditVehicle = new AddEditVehicle(car);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("You Have to select a whole row in order to edit", "Error");
            }
        }

        private void btn_DeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGV_VehicleList.SelectedRows[0].Cells["Id"].Value;

                var car = _db.TypesOfCars.FirstOrDefault(q => q.Id == id);
                //delete
                _db.TypesOfCars.Remove(car);
                _db.SaveChanges();
                dGV_VehicleList.Refresh();
                MessageBox.Show("Delete Success");
            }catch(Exception ex)
            {
                MessageBox.Show("You Have to select a whole row in order to delete", "Error");
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
