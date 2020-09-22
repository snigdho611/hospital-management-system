using HospitalManagementSystem.Windows;
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

namespace HospitalManagementSystem
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUserId.Text) && String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Both fields are empty!");
            }

            else if(String.IsNullOrEmpty(txtUserId.Text))
            {
                MessageBox.Show("Username field is empty!");
            }

            else if (String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Password field is empty!");
            }
            
            else
            {
                try
                {
                    DataAccess access = new DataAccess();
                    string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";

                    access.Connection = new OracleConnection(connectionString);
                    access.Connection.Open();

                    string selectQuery = "select * from admin where username = :p1 and password = :p2";

                    
                    access.Command = new OracleCommand(selectQuery, access.Connection);
                    
                    access.Command.Parameters.Add("p1", OracleDbType.Varchar2).Value = txtUserId.Text;
                    access.Command.Parameters.Add("p2", OracleDbType.Varchar2).Value = txtPass.Text;


                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = new DataTable();
                    access.Adapter.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                        string name = table.Rows[0]["AD_NAME"].ToString();
                        if (table.Rows[0]["AD_PERMIT"].ToString() == "1")
                        {
                            LogInSuccess LG = new LogInSuccess();
                            LG.MakeAdmin();
                            LG.Show(name);
                            LG.ShowDialog();
                            this.Hide();

                            Main M1 = new Main();
                            M1.ShowUserName(table.Rows[0]["AD_NAME"].ToString());
                            M1.AdminAccess();
                            M1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            LogInSuccess LG = new LogInSuccess();
                            LG.Show(table.Rows[0]["AD_NAME"].ToString());
                            LG.ShowDialog();
                            this.Hide();

                            Main M1 = new Main();
                            M1.ShowUserName(table.Rows[0]["AD_NAME"].ToString());
                            M1.ShowDialog();
                            this.Close();
                        }
                    }
                    else 
                    {
                        MessageBox.Show("INVALID USERNAME OR PASSWORD");
                    }
                }

                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
