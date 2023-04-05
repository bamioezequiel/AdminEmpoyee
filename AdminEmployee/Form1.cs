using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminEmployee.PL;

namespace AdminEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepartament_Click(object sender, EventArgs e)
        {
            frmDepartament formDepartament = new frmDepartament();
            formDepartament.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee formEmployee = new frmEmployee();
            formEmployee.ShowDialog();
        }
    }
}
