using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{
    public partial class paymentform : Form
    {
        List<Ipay> pays;
        public paymentform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pays=finantial.set();
            txtallincome.Text = finantial.getallincome().ToString();
            txtempsalary.Text = Convert.ToString(finantial.allsalary);
            txtmedicalex.Text = Convert.ToString(finantial.allmedcalex);
            dataGridView1.DataSource = pays;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path1 = rateform.getpath() + "\\income.txt";
            string path2 = rateform.getpath() + "medicalexpnses.txt";
            System.IO.File.Delete(path1);
            System.IO.File.Delete(path2);

        }
    }
}
