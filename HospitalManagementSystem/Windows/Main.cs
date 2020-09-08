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
            OracleConnection connection = null;
            OracleCommand command = null;
            //OracleDataReader reader = null;

            try
            {
                /*
                string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";

                connection = new OracleConnection(connectionString);
                connection.Open();

                OracleParameter parameter = new OracleParameter();

                command = new OracleCommand("select * from DOCTORS", connection);
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(reader);
                dataGridView1.DataSource = DT;*/

                using (OracleConnection conn = new OracleConnection("Data Source=localhost;User ID=SNIGDHO;Password=student;"))
                using (OracleCommand cmd = new OracleCommand("select * from DOCTORS", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
