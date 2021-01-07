using System;
using System.Collections.Generic;
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
            List<employes> emp = new List<employes>();
            emp = readandwriteemp.set();
            for (int i = 0; i < emp.Count; i++)
            {
                if (txtid.Text == emp[i].idnumber)
                {
                    MessageBox.Show("eror:two same idnumber or person");
                    return;
                }

            }
            string path = rateform.getpath() + "\\eminfo.txt";
            string pathsaveaccount = rateform.getpath() + "\\account.txt";
            string eminfo = txtname.Text + '*' + txtfamilyname.Text + '*' + txtsalary.Text + '*' + txtjob.Text + '*' + txtid.Text + '*' + txtaccount.Text + '*' + 0 + "\n";
            System.IO.File.AppendAllText(path, eminfo);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if(control is TextBox text)
                {
                    text.Text = "";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = readandwriteemp.getall();
            
            dataGridView2.Update();
            dataGridView2.Refresh();
        }
    }
}
