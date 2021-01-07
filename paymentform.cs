﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

            pays = finantial.set();
            txtallincome.Text = finantial.getallincome().ToString();
            txtempsalary.Text = Convert.ToString(finantial.allsalary);
            txtmedicalex.Text = Convert.ToString(finantial.allmedcalex);

            if (pays == null)
            {
                MessageBox.Show("not enogh cash");
                return;
            }



            dataGridView1.DataSource = pays;
            string path1 = rateform.getpath() + "\\income.txt";
            string path2 = rateform.getpath() + "medicalexpnses.txt";
            System.IO.File.Delete(path1);
            System.IO.File.Delete(path2);


        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            DialogResult x = MessageBox.Show("do you want to clear checkoutemployee file too?","", MessageBoxButtons.YesNo);
            if(x==DialogResult.Yes)
            {
                string pathckeck = rateform.getpath() + "\\checkoutemployee.txt";
                System.IO.File.Delete(pathckeck);

            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
