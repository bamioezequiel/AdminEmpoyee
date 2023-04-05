using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AdminEmployee.BLL;
using AdminEmployee.DAL;

namespace AdminEmployee.PL
{
    public partial class frmDepartament : Form
    {
        DepartamentDAL oDepartament;
        public frmDepartament()
        {
            oDepartament = new DepartamentDAL();
            InitializeComponent();
            LoadGrid();
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {          
            oDepartament.Add(GetInformation());
            LoadGrid();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            oDepartament.Delete(GetInformation());
            LoadGrid();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            oDepartament.Update(GetInformation());
            LoadGrid();
            ClearInputs();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void Select(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            dgvDepartament.ClearSelection();
            if (index >= 0)
            {
                txtID.Text = dgvDepartament.Rows[index].Cells[0].Value.ToString();
                txtNameDepartament.Text = dgvDepartament.Rows[index].Cells[1].Value.ToString();

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnCancel.Enabled = true;
            }           
        }

        private DepartamentBLL GetInformation()
        {
            DepartamentBLL oDeparatament = new DepartamentBLL();
            int id = 0; int.TryParse(txtID.Text, out id);

            oDeparatament.ID = id;
            oDeparatament.Departament = txtNameDepartament.Text;

            return oDeparatament;
        }

        public void LoadGrid()
        {
            dgvDepartament.DataSource = oDepartament.GetDepartament().Tables[0];

            dgvDepartament.Columns[0].HeaderText = "ID";
            dgvDepartament.Columns[1].HeaderText = "Departament";

        }

        public void ClearInputs()
        {
            txtID.Text = "";
            txtNameDepartament.Text = "";

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }
    }
}
