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

                DataTable Table = new DataTable();
                Table.Load(reader);
                dataGridView1.DataSource = Table;
                dataGridView1.Visible = true;

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
                dataGridView1.DataSource = dTable;
                dataGridView1.Visible = true;

                tblLbl.Text = "Patients";
                tblLbl.Visible = true;
            }

            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }
    }
}
