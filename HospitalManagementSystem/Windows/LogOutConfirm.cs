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
    public partial class LogOutConfirm : Form
    {
        public LogOutConfirm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
            this.Close();*/
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
