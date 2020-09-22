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
                
                access.Command = new OracleCommand("select * from getAllDoctors", access.Connection);
                OracleDataReader reader = access.Command.ExecuteReader();

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
                string selectPatientQuery = "SELECT * FROM getAllPatients";

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
                    string searchBoxQuery = "SELECT * FROM getAllPatients where PATIENT_ID like :p1 || '%'";
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
                    string searchBoxQuery = "SELECT * FROM getAllPatients where NAME like :p1 || '%'";
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
                    string searchBoxQuery = "select * from getAllDoctors where DOCTOR_ID like :p || '%'";
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
                    string searchBoxQuery = "select * from getAllDoctors where NAME like :p || '%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = searchBox.Text;
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                //Admins
                else if (selectedItem == "ID" && tblLbl.Text == "Admins")
                {
                    string searchBoxQuery = "select * from getAllAdmins where ADMIN_ID like :p || '%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = searchBox.Text;
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                else if (selectedItem == "Name" && tblLbl.Text == "Admins")
                {
                    string searchBoxQuery = "select * from getAllAdmins where NAME like :p || '%'";
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
                    searchBox.Text = "";

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
                    DischargeConfirm Discharge = new DischargeConfirm();
                    Discharge.LoadName(patientName);
                    Discharge.Row(selectedRow);
                    Discharge.ShowDialog();
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

        private void btnDept_Click(object sender, EventArgs e)
        {

        }

        private void usrBtn_Click(object sender, EventArgs e)
        {
            btnDischarge.Enabled = true;

            try
            {
                string selectPatientQuery = "SELECT * FROM getAllAdmins";

                DataAccess access = new DataAccess();

                DataTable table = access.ExecuteQueryTable(selectPatientQuery);
                dataGridViewMain.Refresh();
                dataGridViewMain.DataSource = table;
                dataGridViewMain.Visible = true;

                tblLbl.Text = "Admins";
                tblLbl.Visible = true;
                access.Connection.Close();
            }

            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void addDocBtn_Click(object sender, EventArgs e)
        {
            AddDoctor AddDoc = new AddDoctor();
            AddDoc.ShowDialog();
        }

        private void delPtnBtn_Click(object sender, EventArgs e)
        {
            if(tblLbl.Text == "Patients")
            {
                int countRows = dataGridViewMain.SelectedRows.Count;
                if(countRows == 1)
                {
                    try
                    {
                        DataAccess access = new DataAccess();
                        int selectedRowIndex = dataGridViewMain.SelectedRows[0].Index;
                        DataGridViewRow selectedRow = dataGridViewMain.Rows[selectedRowIndex];
                        dataGridViewMain.ClearSelection();

                        string deleteQuery = "delete from patients where pat_id = :p1";
                        access.Command = new OracleCommand(deleteQuery, access.Connection);
                        access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = selectedRow.Cells["patient_id"].Value.ToString();
                        //MessageBox.Show(deleteQuery + selectedRow.Cells["patient_id"].Value.ToString());
                        access.Command.ExecuteNonQuery();
                        MessageBox.Show()
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
            }
        }
    }
}
