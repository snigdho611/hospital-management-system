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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void docBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";
                OracleConnection connection = new OracleConnection(connectionString);
                OracleCommand command = new OracleCommand("select * from DOCTORS", connection);

                connection.Open();
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
            try
            {
                DataAccess access = new DataAccess();
                string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";
                string selectPatientQuery = "select PAT_ID AS PATIENT_ID, PAT_NAME AS NAME, AGE, DIAGNOSIS, DOC_ID AS DOCTOR_ID, ROOM_NO AS WARD, BILL, TO_DATE(ADMITTED, 'DD/MM/YY')AS ADMITTED from PATIENTS";
                access.Connection = new OracleConnection(connectionString);
                access.Connection.Open();

                access.Adapter = new OracleDataAdapter(access.Command);
                DataTable table = access.ExecuteQueryTable(selectPatientQuery);
                access.Adapter.Fill(table);
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
                string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";

                DataAccess access = new DataAccess();
                access.Connection = new OracleConnection(connectionString);
                access.Connection.Open();

                string selectedItem = comboBox1.Text;

                //Patients
                if (selectedItem == "ID" && tblLbl.Text == "Patients")
                {
                    string searchBoxQuery = "select * from PATIENTS where PAT_ID like '" + searchBox.Text + "%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                else if (selectedItem == "Name" && tblLbl.Text == "Patients")
                {
                    string searchBoxQuery = "select * from PATIENTS where PAT_NAME like '" + searchBox.Text + "%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                

                //Doctors
                else if (selectedItem == "ID" && tblLbl.Text == "Doctors")
                {
                    string searchBoxQuery = "select * from DOCTORS where DOC_ID like '" + searchBox.Text + "%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);
                    dataGridViewMain.DataSource = table;
                    dataGridViewMain.Visible = true;
                }
                else if (selectedItem == "Name" && tblLbl.Text == "Doctors")
                {
                    string searchBoxQuery = "select * from DOCTORS where DOC_NAME like '" + searchBox.Text + "%'";
                    access.Command = new OracleCommand(searchBoxQuery, access.Connection);
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
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
        }
    }
}
