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
    public partial class UpdatePatient : Form
    {
        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";
                    OracleConnection connection = new OracleConnection(connectionString);

                    string updatePatientQuery = "select * from patients where pat_id = :pid";
                    

                    OracleCommand command = new OracleCommand(
                       updatePatientQuery, connection);

                    connection.Open();

                    command.Parameters.Add("pid", OracleDbType.Varchar2).Value = txtName.Text;
                    /*
                    string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";
                    OracleConnection connection = new OracleConnection(connectionString);

                    string updatePatientQuery = "BEGIN updatePatient(:p1, :p2, :p3, :p4, :p5, :p6, :p7, :p8, :p9); END; ";

                    OracleCommand command = new OracleCommand(
                       updatePatientQuery, connection);
                    connection.Open();

                    command.Parameters.Add("p1", OracleDbType.Varchar2).Value = txtName.Text;
                    command.Parameters.Add("p2", OracleDbType.Varchar2).Value = cmbGender.Text.ToString();
                    command.Parameters.Add("p3", OracleDbType.Varchar2).Value = txtAge.Text;
                    command.Parameters.Add("p4", OracleDbType.Varchar2).Value = txtDgn.Text;
                    command.Parameters.Add("p5", OracleDbType.Varchar2).Value = txtDocId.Text;
                    command.Parameters.Add("p6", OracleDbType.Varchar2).Value = txtRoom.Text;
                    command.Parameters.Add("p7", OracleDbType.Varchar2).Value = txtBill.Text;
                    command.Parameters.Add("p8", OracleDbType.Varchar2).Value = "'"+;

                    int rowsUpdated = command.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not inserted");
                    }
                    else
                    {
                        MessageBox.Show("Successfully inserted new patient!");
                    }
                    */

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
        }
    }
}
