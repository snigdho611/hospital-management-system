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
    public partial class DoctorConfirm : Form
    {
        public DoctorConfirm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();
        }
    }
}
