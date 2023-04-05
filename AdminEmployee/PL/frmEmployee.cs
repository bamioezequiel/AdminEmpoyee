using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AdminEmployee.BLL;
using AdminEmployee.DAL;

namespace AdminEmployee.PL
{
    public partial class frmEmployee : Form
    {
        DepartamentDAL oDepartament;
        EmployeeDAL oEmployee;
        byte[] imageByte;

        public frmEmployee()
        {
            InitializeComponent();
            oDepartament = new DepartamentDAL();
            oEmployee = new EmployeeDAL();
            LoadGrid();
            ClearInputs();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            cbxDepartament.DataSource = oDepartament.GetDepartament().Tables[0];
            cbxDepartament.DisplayMember = "departament";
            cbxDepartament.ValueMember = "ID";
        }       

        private EmployeeBLL GetInformation()
        {
            EmployeeBLL employee = new EmployeeBLL();
            int id = 1; 
            int.TryParse(txtID.Text, out id);

            employee.ID = id;
            employee.Name = txtName.Text;
            employee.Lastname = txtLastname.Text;
            employee.Email = txtEmail.Text;
            employee.Image = imageByte;

            int idDepartament = 0;
            int.TryParse(cbxDepartament.SelectedValue.ToString(), out idDepartament);
            employee.Departament = idDepartament;
          
            return employee;
        }

        public void LoadGrid()
        {
            dgvEmployee.DataSource = oEmployee.GetEmployee().Tables[0];

            dgvEmployee.Columns[0].HeaderText = "ID";
            dgvEmployee.Columns[1].HeaderText = "Name";
            dgvEmployee.Columns[2].HeaderText = "Lastname";
            dgvEmployee.Columns[3].HeaderText = "Email";
            dgvEmployee.Columns[4].HeaderText = "ID Departament";
            dgvEmployee.Columns[5].HeaderText = "Image";

        }

        public void ClearInputs()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            
            cbxDepartament.DataSource = oDepartament.GetDepartament().Tables[0];
            cbxDepartament.DisplayMember = "departament";
            cbxDepartament.ValueMember = "ID";

            picImage.Image = null;

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            oEmployee.Delete(GetInformation());
            LoadGrid();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            oEmployee.Update(GetInformation());
            LoadGrid();
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            oEmployee.Add(GetInformation());
            LoadGrid();
            ClearInputs();
        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectedImage = new OpenFileDialog();
            selectedImage.Title = "Select an Image";

            if(selectedImage.ShowDialog() == DialogResult.OK)
            {
                picImage.Image = Image.FromStream(selectedImage.OpenFile());
                MemoryStream memory = new MemoryStream();
                picImage.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
                imageByte = memory.GetBuffer();
                
            }
        }

        private void Select(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            dgvEmployee.ClearSelection();
            if (index >= 0)
            {
                txtID.Text = dgvEmployee.Rows[index].Cells[0].Value.ToString();
                txtName.Text = dgvEmployee.Rows[index].Cells[1].Value.ToString();
                txtLastname.Text = dgvEmployee.Rows[index].Cells[2].Value.ToString();
                txtEmail.Text = dgvEmployee.Rows[index].Cells[3].Value.ToString();

                imageByte = (byte[])dgvEmployee.Rows[index].Cells[5].Value;
                MemoryStream ms = new MemoryStream(imageByte);
                picImage.Image = Image.FromStream(ms);

                int dataDepartament = Convert.ToInt32(dgvEmployee.Rows[index].Cells[4].Value.ToString());
                cbxDepartament.SelectedValue = dataDepartament;
                
                

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnCancel.Enabled = true;
            }
        }
    }
}
