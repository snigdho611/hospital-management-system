﻿using Oracle.ManagedDataAccess.Client;
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
                    MessageBox.Show("Are you sure you want to discharge " + patientName + "?");
                    dataGridViewMain.ClearSelection();

                    string dischargeQuery = "begin dischargeprocess(:p1); Bill(:p2); end;";

                   // string dischargeQuery = "declare patientInfo patients% rowtype; patientID patients.pat_id % type:= 310021; output varchar2(1000); begin output:= printPatient(patientInfo, patientID); dbms_output.put_line(output); end; ";
                    DataAccess access = new DataAccess();
                    access.Command = new OracleCommand(dischargeQuery, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
                    int rowsAffected = access.Command.ExecuteNonQuery();
                    //MessageBox.Show("Successfully discharged ");
                    //MessageBox.Show(selectedRow.Cells["PATIENT_ID"].Value.ToString());
                    //access.Command.CommandText = "declare patientInfo patients% rowtype; patientID patients.pat_id % type:= 310021; output varchar2(1000); begin output:= printPatient(patientInfo, patientID); dbms_output.put_line(output); end; ";
                    //access.Command.CommandType = CommandType.Text;

                    //OracleParameter output = new OracleParameter("output", OracleDbType.Varchar2);
                    //output.Direction = ParameterDirection.ReturnValue;

                    //access.Command.Parameters.Add(output);

                    //access.Command.ExecuteNonQuery();

                    //string Stage = output.Value.ToString();
                    //MessageBox.Show(Stage);

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
            }

            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
