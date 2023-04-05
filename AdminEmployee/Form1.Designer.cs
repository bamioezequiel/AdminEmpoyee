
namespace AdminEmployee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDepartament = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartament
            // 
            this.btnDepartament.Location = new System.Drawing.Point(12, 46);
            this.btnDepartament.Name = "btnDepartament";
            this.btnDepartament.Size = new System.Drawing.Size(162, 93);
            this.btnDepartament.TabIndex = 0;
            this.btnDepartament.Text = "Department";
            this.btnDepartament.UseVisualStyleBackColor = true;
            this.btnDepartament.Click += new System.EventHandler(this.btnDepartament_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(223, 46);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(162, 93);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 170);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnDepartament);
            this.Name = "Form1";
            this.Text = "Admin Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartament;
        private System.Windows.Forms.Button btnEmployee;
    }
}

