
namespace CarRentalApp
{
    partial class ManageVehicleListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGV_VehicleList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddCar = new System.Windows.Forms.Button();
            this.btn_EditCar = new System.Windows.Forms.Button();
            this.btn_DeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_VehicleList)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_VehicleList
            // 
            this.dGV_VehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_VehicleList.Location = new System.Drawing.Point(12, 97);
            this.dGV_VehicleList.Name = "dGV_VehicleList";
            this.dGV_VehicleList.Size = new System.Drawing.Size(567, 211);
            this.dGV_VehicleList.TabIndex = 0;
            this.dGV_VehicleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_VehicleList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Vehicle Listing";
            // 
            // btn_AddCar
            // 
            this.btn_AddCar.Location = new System.Drawing.Point(12, 358);
            this.btn_AddCar.Name = "btn_AddCar";
            this.btn_AddCar.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCar.TabIndex = 2;
            this.btn_AddCar.Text = "Add New Car";
            this.btn_AddCar.UseVisualStyleBackColor = true;
            this.btn_AddCar.Click += new System.EventHandler(this.btn_AddCar_Click);
            // 
            // btn_EditCar
            // 
            this.btn_EditCar.Location = new System.Drawing.Point(93, 358);
            this.btn_EditCar.Name = "btn_EditCar";
            this.btn_EditCar.Size = new System.Drawing.Size(75, 23);
            this.btn_EditCar.TabIndex = 3;
            this.btn_EditCar.Text = "Edit Car";
            this.btn_EditCar.UseVisualStyleBackColor = true;
            this.btn_EditCar.Click += new System.EventHandler(this.btn_EditCar_Click);
            // 
            // btn_DeleteCar
            // 
            this.btn_DeleteCar.Location = new System.Drawing.Point(174, 358);
            this.btn_DeleteCar.Name = "btn_DeleteCar";
            this.btn_DeleteCar.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteCar.TabIndex = 4;
            this.btn_DeleteCar.Text = "Delete Car";
            this.btn_DeleteCar.UseVisualStyleBackColor = true;
            this.btn_DeleteCar.Click += new System.EventHandler(this.btn_DeleteCar_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 393);
            this.Controls.Add(this.btn_DeleteCar);
            this.Controls.Add(this.btn_EditCar);
            this.Controls.Add(this.btn_AddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_VehicleList);
            this.Name = "ManageVehicleListing";
            this.Text = "ManageVechicleListing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_VehicleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_VehicleList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddCar;
        private System.Windows.Forms.Button btn_EditCar;
        private System.Windows.Forms.Button btn_DeleteCar;
    }
}