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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtName.Text) == false || 
                String.IsNullOrWhiteSpace(txtUsr.Text) == false ||
                String.IsNullOrWhiteSpace(txtPass.Text) == false ||
                String.IsNullOrWhiteSpace(txtCnfPass.Text) == false)
            {
                if(txtPass.Text == txtCnfPass.Text)
                {
                    string insertAdmin = "insert into admin(ad_name, email, phone, username, password) values(:p1, :p2, :p3, :p4, :p5)";
                    DataAccess access = new DataAccess();

                    access.Command = new OracleCommand(insertAdmin, access.Connection);
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = txtName.Text;
                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = txtEmail.Text;
                    access.Command.Parameters.Add("p3", OracleDbType.Varchar2).Value = txtPhn.Text;
                    access.Command.Parameters.Add("p4", OracleDbType.Varchar2).Value = txtUsr.Text;
                    access.Command.Parameters.Add("p5", OracleDbType.Varchar2).Value = txtPass.Text;

                    access.Command.ExecuteNonQuery();
                    MessageBox.Show("Successfully added user!");
                }
                else
                {
                    MessageBox.Show("Must match");
                }
            }
            else
            {
                MessageBox.Show("Mandate fields empty");
            }
        }
    }
}
