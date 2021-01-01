using System;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class paymentform : Form
    {
        public paymentform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finantial.set();
            txtallincome.Text = finantial.getallincome().ToString();
            txtempsalary.Text = Convert.ToString(finantial.allsalary);
            txtmedicalex.Text = Convert.ToString(finantial.allmedcalex);
            txtallcheck.Text = finantial.finalcheckout();

        }
    }
}
