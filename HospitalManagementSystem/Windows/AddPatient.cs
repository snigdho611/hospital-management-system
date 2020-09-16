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



                //OracleCommand command = new OracleCommand("INSERT INTO PATIENTS(pat_name, gender, age, diagnosis, doc_id, room_no) values(:pName, :pGender, :pAge, :pDiagnosis, :pDocId, :pRoomNo)", connection);
                OracleCommand command = new OracleCommand("INSERT INTO PATIENTS(pat_name) values(:pName)", connection);
                connection.Open();

                command.Parameters.Add("pName", OracleDbType.Varchar2).Value = "ABCD";
                    //command.Parameters.Add("pGender", OracleDbType.Varchar2).Value = "ABCD";
                    //cmd.Parameters.Add("p3", OracleDbType.Varchar2).Value = txtpass.Text;
                    int rowsUpdated = command.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not inserted");
                    }
                    else
                    {
                        MessageBox.Show("Success!");
                        MessageBox.Show("User has been created");
                    }
                
            }
            catch (Exception E)
            {

            }

        }
    }
}
