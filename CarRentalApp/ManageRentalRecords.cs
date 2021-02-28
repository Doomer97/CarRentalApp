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
    public partial class ManageRentalRecords : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecords()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        void populateData()
        {
            try
            {
                var record = _db.CarRentalRecord
                    .Select(q => new
                    {
                        Customer = q.CustomerName,
                        DateOut = q.DateRented,
                        DateIn = q.DateReturned,
                        Id = q.id,
                        Cost = q.Cost,
                        Car=q.TypesOfCars.Make+" "+q.TypesOfCars.Model
                    }).ToList();
                dGV_RecordList.DataSource = record;
                dGV_RecordList.Columns["Id"].Visible = false;
                dGV_RecordList.Columns["DateIn"].HeaderText = "Date In";
                dGV_RecordList.Columns["DateOut"].HeaderText = "Date Out";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection with database could not be established");
            }
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            populateData();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            populateData();
        }

        private void btn_EditCar_Click(object sender, EventArgs e)
        {
            try
            {
                // get id
                //We expect Int here (data type from database column). otherwise use var./ need casting
                int id = (int)dGV_RecordList.SelectedRows[0].Cells["Id"].Value;
                //query
                var record = _db.CarRentalRecord.FirstOrDefault(q => q.id == id);

                // launch addeditvehicle window with data

                var addEditRentalRecord = new AddEditRentalRecord(record)
                {
                    MdiParent = this.MdiParent
                };
                addEditRentalRecord.Show();
                
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
                int id = (int)dGV_RecordList.SelectedRows[0].Cells["Id"].Value;

                var record = _db.CarRentalRecord.FirstOrDefault(q => q.id == id);
                //delete
                _db.CarRentalRecord.Remove(record);
                _db.SaveChanges();
                //dGV_RecordList.Refresh();
                MessageBox.Show("Delete Success");
                populateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You Have to select a whole row in order to delete", "Error");
            }
        }

        private void btn_AddCar_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord addEditRentalRecord = new AddEditRentalRecord();
            addEditRentalRecord.MdiParent = this.MdiParent;
            addEditRentalRecord.Show();
        }
    }
}
