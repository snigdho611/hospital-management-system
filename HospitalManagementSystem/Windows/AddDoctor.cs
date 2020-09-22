using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Windows
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void lblBDT_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeptID.Text ==  "10")
            {
                txtDepartment.Text = "CARDIOLOGY";
            }
            else if (cmbDeptID.Text == "20")
            {
                txtDepartment.Text = "NEPHROLOGY";
            }
            else if (cmbDeptID.Text == "30")
            {
                txtDepartment.Text = "ONCOLOGY";
            }
            else if (cmbDeptID.Text == "40")
            {
                txtDepartment.Text = "GASTROLOGY";
            }
            else if (cmbDeptID.Text == "50")
            {
                txtDepartment.Text = "CARDIOLOGY";
            }
            else if (cmbDeptID.Text == "60")
            {
                txtDepartment.Text = "NEUROLOGY";
            }
            else
            {

            }
        }
    }
}
