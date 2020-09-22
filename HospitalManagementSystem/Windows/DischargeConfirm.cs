using System.IO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
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

        private DataGridViewRow selectedRow;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dischargeQuery = "begin dischargeprocess(:p1); Bill(:p2);  end;";

                DataAccess access = new DataAccess();
                access.Command = new OracleCommand(dischargeQuery, access.Connection);
                access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
                access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
                OracleDataReader reader = access.Command.ExecuteReader();

                DataTable dTable = new DataTable();
                dTable.Load(reader);

                if (dTable.Rows.Count > 0)
                {
                    using (StreamWriter sr = new StreamWriter("D:\\GitHub\\HospitalManagementSystem\\Receipts\\receipt.txt", true))
                    {
                        //Console.WriteLine("Receipt");
                        sr.WriteLine("Receipt");
                    }

                    Discharged dis = new Discharged();
                    //this.Hide();
                    dis.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        public void Row(DataGridViewRow selectedRow)
        {
            this.selectedRow = selectedRow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
