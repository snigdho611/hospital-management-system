using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
            else if (cmbDeptID.Text == "70")
            {
                txtDepartment.Text = "PEDIATRICS";
            }
            else
            {

            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                MessageBox.Show("Name field cannot be empty!");
            }
            else
            {
                try
                {
                    DataAccess access = new DataAccess();
                    string insertPatientQuery = "begin insertDoctor(:p1, TO_DATE(:p2, 'DD-MM-YYYY'), :p3, :p4, TO_DATE(:p5, 'DD-MM-YYYY'), :p6); end;";
                    
                    access.Command = new OracleCommand(
                       insertPatientQuery, access.Connection);


                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = txtName.Text;
                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = dtpHire.Value.Date.ToString("dd-MM-yyyy");
                    access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = txtSalary.Text;
                    access.Command.Parameters.Add("p4", OracleDbType.Varchar2).Value = txtNationality.Text;
                    access.Command.Parameters.Add("p5", OracleDbType.Varchar2).Value = dtpDOB.Value.Date.ToString("dd-MM-yyyy");
                    access.Command.Parameters.Add("p6", OracleDbType.Varchar2).Value = cmbDeptID.Text;

                    int rowsUpdated = access.Command.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not inserted");
                    }
                    else
                    {
                        MessageBox.Show("Successfully inserted new Doctor!");
                    }

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
