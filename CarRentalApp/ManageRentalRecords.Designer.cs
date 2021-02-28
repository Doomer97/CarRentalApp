
namespace CarRentalApp
{
    partial class ManageRentalRecords
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_DeleteCar = new System.Windows.Forms.Button();
            this.btn_EditCar = new System.Windows.Forms.Button();
            this.btn_AddCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_RecordList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(394, 331);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_DeleteCar
            // 
            this.btn_DeleteCar.Location = new System.Drawing.Point(301, 331);
            this.btn_DeleteCar.Name = "btn_DeleteCar";
            this.btn_DeleteCar.Size = new System.Drawing.Size(87, 23);
            this.btn_DeleteCar.TabIndex = 10;
            this.btn_DeleteCar.Text = "Delete Record";
            this.btn_DeleteCar.UseVisualStyleBackColor = true;
            this.btn_DeleteCar.Click += new System.EventHandler(this.btn_DeleteCar_Click);
            // 
            // btn_EditCar
            // 
            this.btn_EditCar.Location = new System.Drawing.Point(220, 331);
            this.btn_EditCar.Name = "btn_EditCar";
            this.btn_EditCar.Size = new System.Drawing.Size(75, 23);
            this.btn_EditCar.TabIndex = 9;
            this.btn_EditCar.Text = "Edit Record";
            this.btn_EditCar.UseVisualStyleBackColor = true;
            this.btn_EditCar.Click += new System.EventHandler(this.btn_EditCar_Click);
            // 
            // btn_AddCar
            // 
            this.btn_AddCar.Location = new System.Drawing.Point(139, 331);
            this.btn_AddCar.Name = "btn_AddCar";
            this.btn_AddCar.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCar.TabIndex = 8;
            this.btn_AddCar.Text = "Add New Record";
            this.btn_AddCar.UseVisualStyleBackColor = true;
            this.btn_AddCar.Click += new System.EventHandler(this.btn_AddCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Rental Listing";
            // 
            // dGV_RecordList
            // 
            this.dGV_RecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_RecordList.Location = new System.Drawing.Point(29, 96);
            this.dGV_RecordList.Name = "dGV_RecordList";
            this.dGV_RecordList.Size = new System.Drawing.Size(567, 211);
            this.dGV_RecordList.TabIndex = 6;
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 376);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_DeleteCar);
            this.Controls.Add(this.btn_EditCar);
            this.Controls.Add(this.btn_AddCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_RecordList);
            this.Name = "ManageRentalRecords";
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_DeleteCar;
        private System.Windows.Forms.Button btn_EditCar;
        private System.Windows.Forms.Button btn_AddCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_RecordList;
    }
}