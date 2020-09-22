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
    public partial class DoctorConfirm : Form
    {
        public DoctorConfirm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();
            string searchDoctor = "select * from doctors where doc_id = :p1";

            access.Command = new OracleCommand(searchDoctor, access.Connection);
            access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = txtDocId.Text;
            OracleDataReader reader = access.Command.ExecuteReader();

            DataTable dTable = new DataTable();
            dTable.Load(reader);

            if(dTable.Rows.Count > 0)
            {
                AddPatient addPatient = new AddPatient();
                addPatient.LoadDoctor(dTable.Rows[0]["DOC_NAME"].ToString(), txtDocId.Text);
                addPatient.ShowDialog();
            }
            else
            {
                MessageBox.Show("Doctor not found!");
            }
            
        }
    }
}
