using System;
using Oracle.ManagedDataAccess.Client;
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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";
                OracleConnection connection = new OracleConnection(connectionString);

                string insertPatientQuery = "begin insertPatient('"
                    + txtName.Text + "', '"
                    + cmbGender.Text.ToString() + "', "
                    + txtAge.Text + ", '"
                    + txtDgn.Text + "', "
                    + txtDocId.Text + ", "
                    + txtRoom.Text + ", "
                    + txtBill.Text + "); end;";

               // string insertPatientQuery = "begin insertPatient(:p1, :p2, :p3, :p4, :p5, :p6, :p7); end;";

                OracleCommand command = new OracleCommand(
                   insertPatientQuery, connection);
                connection.Open();

                txtBill.Text = insertPatientQuery;
                /*
                command.Parameters.Add("p1", OracleDbType.NVarchar2).Value = txtName.Text;
                command.Parameters.Add("p2", OracleDbType.NVarchar2).Value = cmbGender.Text.ToString();
                command.Parameters.Add("p3", OracleDbType.NVarchar2).Value = Convert.ToInt32(txtAge.Text);
                command.Parameters.Add("p4", OracleDbType.NVarchar2).Value = txtDgn.Text;
                command.Parameters.Add("p5", OracleDbType.NVarchar2).Value = Convert.ToInt32(txtDocId.Text);
                command.Parameters.Add("p6", OracleDbType.NVarchar2).Value = Convert.ToInt32(txtRoom.Text);
                command.Parameters.Add("p7", OracleDbType.NVarchar2).Value = Convert.ToInt32(txtBill.Text);
                */
                txtBill.Text = insertPatientQuery;

                int rowsUpdated = command.ExecuteNonQuery();
                if (rowsUpdated == 0)
                {
                    MessageBox.Show("Record not inserted");
                }
                else
                {
                    MessageBox.Show("Successfully inserted new patient!");
                }

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

        }
    }
}
