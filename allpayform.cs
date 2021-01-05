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
    public partial class allpayform : Form
    {
        public allpayform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void allpayform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\medicalexpnses.txt";
            string pathckeck = rateform.getpath() + "\\checkoutemployee.txt";
            string pathsaveaccount = rateform.getpath() + "\\account.txt";
            textBox1.Text = System.IO.File.ReadAllText(pathckeck) + "\n"+System.IO.File.ReadAllText(path)+"\n"+ System.IO.File.ReadAllText(pathsaveaccount);
        
          
           
        }

    }
}
