using System;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class sharmanform : Form
    {
        string path = Application.StartupPath + @"\shareman.txt";
        public sharmanform()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
            string information = txtname.Text + '*' + txtfamilyname.Text + '*' + txtsalpercent.Text + '*' + txtsharepercent.Text + '*' + txtid.Text + '*' + txtaccount.Text + '*'+0+"\n";
            System.IO.File.AppendAllText(path, information);
        

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
    }
}
