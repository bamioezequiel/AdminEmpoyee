
namespace AdminEmployee.PL
{
    partial class frmEmployee
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.cbxDepartament = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnExamine = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(216, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(216, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(96, 23);
            this.txtId.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(347, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(318, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(216, 89);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(213, 23);
            this.txtLastname.TabIndex = 3;
            // 
            // cbxDepartament
            // 
            this.cbxDepartament.FormattingEnabled = true;
            this.cbxDepartament.Location = new System.Drawing.Point(216, 145);
            this.cbxDepartament.Name = "cbxDepartament";
            this.cbxDepartament.Size = new System.Drawing.Size(449, 23);
            this.cbxDepartament.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(347, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(216, 71);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(58, 15);
            this.lblLastname.TabIndex = 8;
            this.lblLastname.Text = "Lastname";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(457, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Departament";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(13, 21);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(182, 193);
            this.picImage.TabIndex = 12;
            this.picImage.TabStop = false;
            // 
            // btnExamine
            // 
            this.btnExamine.Location = new System.Drawing.Point(12, 220);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(183, 23);
            this.btnExamine.TabIndex = 13;
            this.btnExamine.Text = "Examine";
            this.btnExamine.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(297, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(378, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(492, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 270);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(653, 168);
            this.dgvEmployee.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(457, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExamine);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxDepartament);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.ComboBox cbxDepartament;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnExamine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtEmail;
    }
}