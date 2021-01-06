using System;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class employessalary : Form
    {
        public employessalary()
        {
            InitializeComponent();
        }
        private void save_Click(object sender, EventArgs e)
        {
            string path = rateform.getpath() + "\\eminfo.txt";
            string pathsaveaccount= rateform.getpath() + "\\account.txt"; 
            string eminfo = txtname.Text + '*' + txtfamilyname.Text + '*' + txtsalary.Text + '*' + txtjob.Text + '*' + txtid.Text + '*' + txtaccount.Text+'*'+0 + "\n";
            System.IO.File.AppendAllText(path, eminfo);
         
            Close();

        }
    }
}
