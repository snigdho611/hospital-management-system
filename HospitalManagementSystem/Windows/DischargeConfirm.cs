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
                string AdmittedDate = selectedRow.Cells["ADMITTED"].Value.ToString();
                string dischargeQuery = "begin Bill(:p1); dischargeprocess(:p2);  end;";
                string receiptQuery = "select * from GETALLPATIENTSREFDOCTORS where PATIENT_ID = :p3";
                //MessageBox.Show(selectedRow.Cells["PATIENT_ID"].Value.ToString());

                DataAccess access = new DataAccess();
                access.Command = new OracleCommand(dischargeQuery, access.Connection);
                access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
                access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
                access.Command.ExecuteNonQuery();

                access.Command = new OracleCommand(receiptQuery, access.Connection);
                access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = selectedRow.Cells["PATIENT_ID"].Value;
                access.Adapter = new OracleDataAdapter(access.Command);
                DataTable table = new DataTable();
                access.Adapter.Fill(table);

                try
                {
                    DateTime localDateTime = DateTime.Now;
                    using (StreamWriter sr = new StreamWriter("D:\\GitHub\\HospitalManagementSystem\\Receipts\\receipt" + localDateTime.ToString("_yyyyMMdd-HHmmss") + ".txt"))
                    {
                        //Console.WriteLine("Receipt");
                        sr.WriteLine("--------------Receipt--------------\n" +
                            "Name: " + table.Rows[0]["PATIENT_NAME"].ToString() +
                            "\nAge: " + table.Rows[0]["AGE"].ToString() +
                            "\nGender: " + table.Rows[0]["GENDER"].ToString() +
                            "\nDepartment: " + table.Rows[0]["DEPARTMENT"].ToString() +
                            "\nDoctor: Dr. " + table.Rows[0]["DOCTOR_NAME"].ToString() +
                            "\nBill: " + table.Rows[0]["BILL"].ToString() +
                            "\nAdmitted since: " + AdmittedDate+
                            "\n-----------------------------------" +
                            "\n" + localDateTime.ToString("dddd, dd MMMM yyyy"));
                    }
                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }


                Discharged dis = new Discharged();
                //this.Hide();
                dis.ShowDialog();
                this.Close();
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
