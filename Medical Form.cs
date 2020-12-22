using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class medicalform : Form
    {
        public medicalform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turns tuform = new turns();
            tuform.Show(this);
        }

        private void btnrating_Click(object sender, EventArgs e)
        {
            rateform rateforming = new rateform();
            rateforming.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteturnform detuform = new deleteturnform();
            detuform.Show(this);
        }
    }
}
