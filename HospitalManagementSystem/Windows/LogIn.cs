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
            if(String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Both fields are empty!");
            }

            else if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Username field is empty!");
            }

            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Password field is empty!");
            }
            
            else
            {
                //OracleConnection connection = null;
                //OracleCommand command = null;
                //OracleDataReader reader = null;

                try
                {
                    DataAccess access = new DataAccess();
                    string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";

                    access.Connection = new OracleConnection(connectionString);
                    access.Connection.Open();

                    //connection = new OracleConnection(connectionString);
                    //connection.Open();

                    //OracleParameter parameter = new OracleParameter();

                    string selectQuery = "select * from admin where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
                    access.Command = new OracleCommand(selectQuery, access.Connection);
                    access.Command.CommandType = CommandType.Text;

                    access.Adapter = new OracleDataAdapter(access.Command);
                    DataTable table = access.ExecuteQueryTable(selectQuery);

                    if (table.Rows.Count == 1)
                    {
                        if(table.Rows[0]["AD_PERMIT"].ToString() == "1")
                        {
                            LogInSuccess LG = new LogInSuccess(table.Rows[0]["AD_NAME"].ToString());
                            LG.MakeAdmin();
                            LG.ShowDialog();
                            this.Hide();

                            Main M1 = new Main();
                            M1.AdminAccess();
                            M1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            LogInSuccess LG = new LogInSuccess(table.Rows[0]["AD_NAME"].ToString());
                            LG.ShowDialog();
                            this.Hide();

                            Main M1 = new Main();
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
