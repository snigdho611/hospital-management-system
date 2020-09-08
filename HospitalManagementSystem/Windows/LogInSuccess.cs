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
    public partial class LogInSuccess : Form
    {
        public LogInSuccess(string adminName)
        {
            InitializeComponent();
            this.Show(adminName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
