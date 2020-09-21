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

        private int patientID;

        public int PatientID
        {
            set { this.patientID = value; }
            get { return this.patientID; }
        }

        public void LoadData(DataGridViewRow selectedRow)
        {
            txtName.Text = selectedRow.Cells["NAME"].Value.ToString();
            cmbGender.Text = selectedRow.Cells["GENDER"].Value.ToString();
            txtAge.Text = selectedRow.Cells["AGE"].Value.ToString(); ;
            txtDgn.Text = selectedRow.Cells["DIAGNOSIS"].Value.ToString(); ;
            txtDocId.Text = selectedRow.Cells["DOCTOR_ID"].Value.ToString(); ;
            txtRoom.Text = selectedRow.Cells["WARD"].Value.ToString();
            txtBill.Text = selectedRow.Cells["BILL"].Value.ToString();
        }

        public void LoadDoctor(DataGridViewRow selectedRow)
        {
            DataAccess access = new DataAccess();
            string docQuery = "select * from doctors where doc_id = :p1";
            access.Command = new OracleCommand(docQuery, access.Connection);
            access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = selectedRow.Cells["DOCTOR_ID"].Value.ToString();
            OracleDataReader reader = access.Command.ExecuteReader();

            DataTable dTable = new DataTable();
            dTable.Load(reader);
            //MessageBox.Show(dTable.Rows[0]["DOC_NAME"].ToString());
            txtDocName.Text = dTable.Rows[0]["DOC_NAME"].ToString();
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
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
                    
                    
                    string updatePatientQuery = "BEGIN updatePatient(:p1, :p2, :p3, :p4, :p5, :p6, :p7, to_date(:p8, 'DD-MM-YYYY'), :p9); END; ";

                    access.Command = new OracleCommand(
                       updatePatientQuery, access.Connection);

                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = txtName.Text;
                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = cmbGender.Text.ToString();
                    access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = txtAge.Text;
                    access.Command.Parameters.Add("p4", OracleDbType.Varchar2).Value = txtDgn.Text;
                    access.Command.Parameters.Add("p5", OracleDbType.Varchar2).Value = txtDocId.Text;
                    access.Command.Parameters.Add("p6", OracleDbType.Varchar2).Value = txtRoom.Text;
                    access.Command.Parameters.Add("p7", OracleDbType.Varchar2).Value = txtBill.Text;
                    access.Command.Parameters.Add("p8", OracleDbType.Varchar2).Value = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");
                    access.Command.Parameters.Add("p9", OracleDbType.Varchar2).Value = PatientID.ToString();

                    int rowsUpdated = access.Command.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Failed to update patient information!");
                    }
                    else
                    {
                        MessageBox.Show("Successfully updated patient information!");
                    }
                    

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
        }
    }
}
