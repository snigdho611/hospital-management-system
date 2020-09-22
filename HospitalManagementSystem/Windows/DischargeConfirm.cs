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
    public partial class DischargeConfirm : Form
    {
        public DischargeConfirm()
        {
            InitializeComponent();
        }

        public void LoadName(string patientName)
        {
            this.label4.Text = "Are you sure you want to discharge " + patientName + " ?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = Main.dataGridViewMain.SelectedRows[0].Index;
            DataGridViewRow selectedRow = Main.dataGridViewMain.Rows[selectedRowIndex];
            string patientName = Convert.ToString(selectedRow.Cells["NAME"].Value);
            string dischargeQuery = "begin dischargeprocess(:p1); Bill(:p2);  end;";

            DataAccess access = new DataAccess();
            access.Command = new OracleCommand(dischargeQuery, access.Connection);
            access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
            access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
            int rowsAffected = access.Command.ExecuteNonQuery();
        }

        private void Discharge()
        {

        }
    }
}
