
namespace CarRentalApp
{
    partial class AddRentalRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_CoustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateRented = new System.Windows.Forms.DateTimePicker();
            this.dateReturned = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBox_TypeOfCar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txtBox_Cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Car Rental Record";
            // 
            // txtBox_CoustomerName
            // 
            this.txtBox_CoustomerName.Location = new System.Drawing.Point(12, 111);
            this.txtBox_CoustomerName.Name = "txtBox_CoustomerName";
            this.txtBox_CoustomerName.Size = new System.Drawing.Size(245, 20);
            this.txtBox_CoustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coustomer Name";
            // 
            // dateRented
            // 
            this.dateRented.Location = new System.Drawing.Point(12, 179);
            this.dateRented.Name = "dateRented";
            this.dateRented.Size = new System.Drawing.Size(245, 20);
            this.dateRented.TabIndex = 3;
            // 
            // dateReturned
            // 
            this.dateReturned.Location = new System.Drawing.Point(338, 179);
            this.dateReturned.Name = "dateReturned";
            this.dateReturned.Size = new System.Drawing.Size(256, 20);
            this.dateReturned.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Rented";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(334, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Returned";
            // 
            // cmBox_TypeOfCar
            // 
            this.cmBox_TypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBox_TypeOfCar.FormattingEnabled = true;
            this.cmBox_TypeOfCar.Location = new System.Drawing.Point(12, 245);
            this.cmBox_TypeOfCar.Name = "cmBox_TypeOfCar";
            this.cmBox_TypeOfCar.Size = new System.Drawing.Size(245, 21);
            this.cmBox_TypeOfCar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type Of Car";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_Submit.Location = new System.Drawing.Point(338, 206);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(256, 60);
            this.btn_Submit.TabIndex = 9;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // txtBox_Cost
            // 
            this.txtBox_Cost.Location = new System.Drawing.Point(338, 111);
            this.txtBox_Cost.Name = "txtBox_Cost";
            this.txtBox_Cost.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Cost.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(334, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cost";
            // 
            // AddRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 298);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_Cost);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmBox_TypeOfCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateReturned);
            this.Controls.Add(this.dateRented);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_CoustomerName);
            this.Controls.Add(this.label1);
            this.Name = "AddRentalRecord";
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_CoustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateRented;
        private System.Windows.Forms.DateTimePicker dateReturned;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmBox_TypeOfCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txtBox_Cost;
        private System.Windows.Forms.Label label6;
    }
}

