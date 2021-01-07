using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class sharmanform : Form
    {
        string path = Application.StartupPath + @"\shareman.txt";
        List<shareman> share = new List<shareman>();
        public sharmanform()
        {
            InitializeComponent();
            checkpecent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            check();
            double a=checkpecent();
            if (a == -1)
                return;
            string information = txtname.Text + '*' + txtfamilyname.Text + '*' + txtsalpercent.Text + '*' + txtsharepercent.Text + '*' + txtid.Text + '*' + txtaccount.Text + '*' + 0 + "\n";
            System.IO.File.AppendAllText(path, information);
            checkpecent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control con in panel1.Controls)
            {
                if (con is TextBox)
                {
                    con.Text = "";
                }




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(path);
        }

        private void sharmanform_Load(object sender, EventArgs e)
        {

        }
        public double checkpecent()
        {
            share = readandwritesha.set();
            double percent = 0;
            for (int i = 0; i < share.Count; i++)
            {
                percent += share[i].salary;
            }
            if (percent > 100)
            {
                MessageBox.Show("all pecent is bigger than 100,please clear file and set it true");
                return -1;

            }
            textBox1.Text = percent.ToString();
            return percent;
        }
        public Boolean check()
        {
            
            share = readandwritesha.set();
            for (int i = 0; i < share.Count; i++)
            {
                if (share[i].idnumber == txtid.Text)
                {
                    MessageBox.Show("eror:two same idnumber or person");
                    return false;
                }
              
            }
            return true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = readandwritesha.get();

        }
    }
}
