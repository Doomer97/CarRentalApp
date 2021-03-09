
namespace CarRentalApp
{
    partial class ManageUsers
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
            this.btn_DeactivateUser = new System.Windows.Forms.Button();
            this.btn_ResetPass = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_UserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(433, 327);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // btn_DeactivateUser
            // 
            this.btn_DeactivateUser.Location = new System.Drawing.Point(317, 327);
            this.btn_DeactivateUser.Name = "btn_DeactivateUser";
            this.btn_DeactivateUser.Size = new System.Drawing.Size(110, 23);
            this.btn_DeactivateUser.TabIndex = 16;
            this.btn_DeactivateUser.Text = "Deactivate User";
            this.btn_DeactivateUser.UseVisualStyleBackColor = true;
            this.btn_DeactivateUser.Click += new System.EventHandler(this.btn_DeactivateUser_Click);
            // 
            // btn_ResetPass
            // 
            this.btn_ResetPass.Location = new System.Drawing.Point(215, 327);
            this.btn_ResetPass.Name = "btn_ResetPass";
            this.btn_ResetPass.Size = new System.Drawing.Size(97, 23);
            this.btn_ResetPass.TabIndex = 15;
            this.btn_ResetPass.Text = "Reset Password";
            this.btn_ResetPass.UseVisualStyleBackColor = true;
            this.btn_ResetPass.Click += new System.EventHandler(this.btn_ResetPass_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(93, 327);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(115, 23);
            this.btn_AddUser.TabIndex = 14;
            this.btn_AddUser.Text = "Add New User";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Users";
            // 
            // dGV_UserList
            // 
            this.dGV_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_UserList.Location = new System.Drawing.Point(24, 94);
            this.dGV_UserList.Name = "dGV_UserList";
            this.dGV_UserList.Size = new System.Drawing.Size(567, 211);
            this.dGV_UserList.TabIndex = 12;
            this.dGV_UserList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_UserList_RowHeaderMouseClick);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 391);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_DeactivateUser);
            this.Controls.Add(this.btn_ResetPass);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_UserList);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_UserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_DeactivateUser;
        private System.Windows.Forms.Button btn_ResetPass;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_UserList;
    }
}