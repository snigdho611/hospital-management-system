using Oracle.ManagedDataAccess.Client;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void docBtn_Click(object sender, EventArgs e)
        {
            btnDischarge.Enabled = false;

            try
            {
                
                DataAccess access = new DataAccess();
                
                OracleCommand command = new OracleCommand("select * from DOCTORS", access.Connection);
                OracleDataReader reader = command.ExecuteReader();

                DataTable dTable = new DataTable();
                dTable.Load(reader);
                dataGridViewMain.Refresh();
                dataGridViewMain.DataSource = dTable;
                dataGridViewMain.Visible = true;

                tblLbl.Text = "Doctors";
                tblLbl.Visible = true;
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void ptnBtn_Click(object sender, EventArgs e)
        {
            btnDischarge.Enabled = true;

            try
            {
                
                
                string selectPatientQuery = "select PAT_ID AS PATIENT_ID, PAT_NAME AS NAME, GENDER, AGE, DIAGNOSIS, DOC_ID AS DOCTOR_ID, ROOM_NO AS WARD, BILL, TO_DATE(ADMITTED, 'DD/MM/YY')AS ADMITTED from PATIENTS";

                DataAccess access = new DataAccess();

                DataTable table = access.ExecuteQueryTable(selectPatientQuery);
                dataGridViewMain.Refresh();
                dataGridViewMain.DataSource = table;
                dataGridViewMain.Visible = true;

                tblLbl.Text = "Patients";
                tblLbl.Visible = true;
            }

            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataAccess access = new DataAccess();

                string selectedItem = comboBox1.Text;

                //Patients
                if (selectedItem == "ID" && tblLbl.Text == "Patients")
                {
                    string searchBoxQuery = "select PAT_ID AS PATIENT_ID, PAT_NAME AS NAME, AGE, DIAGNOSIS, DOC_ID AS DOCTOR_ID, ROOM_NO AS WARD, BILL, TO_DATE(ADMITTED, 'DD/MM/YY')AS ADMITTED from PATIENTS where PAT_ID like :p || '%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = searchBox.Text;
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                else if (selectedItem == "Name" && tblLbl.Text == "Patients")
                {
                    string searchBoxQuery = "select PAT_ID AS PATIENT_ID, PAT_NAME AS NAME, AGE, DIAGNOSIS, DOC_ID AS DOCTOR_ID, ROOM_NO AS WARD, BILL, TO_DATE(ADMITTED, 'DD/MM/YY')AS ADMITTED from PATIENTS where PAT_NAME like :p || '%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = searchBox.Text;

                    
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                

                //Doctors
                else if (selectedItem == "ID" && tblLbl.Text == "Doctors")
                {
                    string searchBoxQuery = "select * from DOCTORS where DOC_ID like :p || '%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = searchBox.Text;
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                else if (selectedItem == "Name" && tblLbl.Text == "Doctors")
                {
                    string searchBoxQuery = "select * from DOCTORS where DOC_NAMElike :p || '%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = searchBox.Text;
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                else if(selectedItem == "")
                {
                    MessageBox.Show("No property was selected!");
                }
            }

            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void addPtnBtn_Click(object sender, EventArgs e)
        {
            DoctorConfirm doctorConfirm = new DoctorConfirm();
            doctorConfirm.ShowDialog();
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            try
            {
                int countOfRows = dataGridViewMain.SelectedRows.Count;

                if (countOfRows == 1)
                {
                    int selectedRowIndex = dataGridViewMain.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = dataGridViewMain.Rows[selectedRowIndex];
                    string patientName = Convert.ToString(selectedRow.Cells["NAME"].Value);
                    MessageBox.Show("Are you sure you want to discharge " + patientName+ "? ");
                    dataGridViewMain.ClearSelection();
                }

                else if (countOfRows > 1)
                {
                    MessageBox.Show("You must choose only one patient to Discharge");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countOfRows = dataGridViewMain.SelectedRows.Count;

            if (countOfRows == 1)
            {
                int selectedRowIndex = dataGridViewMain.SelectedRows[0].Index;
                DataGridViewRow selectedRow = dataGridViewMain.Rows[selectedRowIndex];
                dataGridViewMain.ClearSelection();

                UpdatePatient updatePatient = new UpdatePatient();
                updatePatient.LoadData(selectedRow);
                updatePatient.LoadDoctor(selectedRow);
                updatePatient.PatientID = Convert.ToInt32(selectedRow.Cells["PATIENT_ID"].Value);
                //updatePatient.LoadDoctor(dTable.Rows[0]["PAT_ID"].ToString());
                updatePatient.ShowDialog();
            }
            
        }
    }
}
