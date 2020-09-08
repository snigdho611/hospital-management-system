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
                OracleConnection connection = null;
                OracleCommand command = null;
                OracleDataReader reader = null;

                try
                {
                    string connectionString = "Data Source=localhost;User ID=SNIGDHO;Password=student;";

                    connection = new OracleConnection(connectionString);
                    connection.Open();

                    OracleParameter parameter = new OracleParameter();

                    command = new OracleCommand("select AD_NAME from admin where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", connection);
                    command.CommandType = CommandType.Text;

                    reader = command.ExecuteReader();
                    int x = 0;
                    string adminName = " ";

                    while (reader.Read())
                    {
                        x += 1;
                        adminName = reader["AD_NAME"].ToString();
                    }

                    if (x == 1)
                    {
                        LogInSuccess LG = new LogInSuccess(adminName);
                        LG.ShowDialog();
                        this.Hide();

                        Main M1 = new Main();
                        M1.ShowDialog();
                        this.Close();
                    }
                    else if (x == 0)
                    {
                        MessageBox.Show("Invalid username or password");
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
