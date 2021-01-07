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
    public partial class Bimes : Form
    {
        public Bimes()
        {
            InitializeComponent();
        }
        string path = rateform.getpath() + "\\bime.txt";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(readandwritebime.search(txtid.Text)!=null)
            {
                MessageBox.Show("wrong : two same idcode");
                return;
            }
            bime x = new bime(txtname.Text, txtfamilyname.Text, txtid.Text,Convert.ToDouble(txtaccount.Text));
            readandwritebime.writeone(x);

        }

        private void Bimes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = readandwritebime.get();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if(control is TextBox txt)
                {
                    txt.Text = "";
                }

            }
        }
    }
}
