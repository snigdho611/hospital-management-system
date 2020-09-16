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
                string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";
                OracleConnection connection = new OracleConnection(connectionString);
                
                OracleCommand command = new OracleCommand("select * from PATIENTS", connection);

                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                DataTable dTable = new DataTable();
                dTable.Load(reader);
                dataGridViewMain.Refresh();
                dataGridViewMain.DataSource = dTable;
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
                OracleConnection connection = new OracleConnection(connectionString);

                

                connection.Open();

                string selectedItem = comboBox1.Text;

                //Patients
                if (selectedItem == "ID" && tblLbl.Text == "Patients")
                {
                    OracleCommand command = new OracleCommand("select * from PATIENTS where PAT_ID like '" + searchBox.Text + "%'", connection);
                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dTable = new DataTable();
                    dTable.Load(reader);
                    dataGridViewMain.DataSource = dTable;
                    dataGridViewMain.Visible = true;
                }
                else if (selectedItem == "Name" && tblLbl.Text == "Patients")
                {
                    OracleCommand command = new OracleCommand("select * from PATIENTS where PAT_NAME like '" + searchBox.Text + "%'", connection);
                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dTable = new DataTable();
                    dTable.Load(reader);
                    dataGridViewMain.DataSource = dTable;
                    dataGridViewMain.Visible = true;
                }
                

                //Doctors
                else if (selectedItem == "ID" && tblLbl.Text == "Doctors")
                {
                    OracleCommand command = new OracleCommand("select * from Doctors where DOC_ID like '" + searchBox.Text + "%'", connection);
                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dTable = new DataTable();
                    dTable.Load(reader);
                    dataGridViewMain.DataSource = dTable;
                    dataGridViewMain.Visible = true;
                }
                else if (selectedItem == "Name" && tblLbl.Text == "Doctors")
                {
                    OracleCommand command = new OracleCommand("select * from DOCTORS where DOC_NAME like '" + searchBox.Text + "%'", connection);
                    OracleDataReader reader = command.ExecuteReader();
                    DataTable dTable = new DataTable();
                    dTable.Load(reader);
                    dataGridViewMain.DataSource = dTable;
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
    }
}
