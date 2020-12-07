using System;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class Form2 : Form
    {

        string path = Application.StartupPath;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime date = ratetime.Value;
            nobatdehi x;
            string work = "";
            string doctorname = "";
            if (rbExamination.Checked == true)
            {
                work = "moayene";
                doctorname = cbexam.SelectedItem.ToString();
            }
            else if (rb1serface.Checked == true)
            {
                work = "tarmim1";
                doctorname = cbsu1.SelectedItem.ToString();
            }
            else if (rbsurface2.Checked == true)
            {
                work = "tarmim2";
                doctorname = cbsu2.SelectedItem.ToString();

            }
            else if (rbroot.Checked == true)
            {
                work = "darmanreshe";
                doctorname = cbroot.SelectedItem.ToString();
            }
            if (chkhaveid.Checked == true)
            {
                x = new nobatdehi(date, txtfilecode.Text, work,doctorname,chkeven.Checked,chkodd.Checked);
            }
            else
            {
                path = Application.StartupPath;
                string name = txtname.Text;
                string familyname = txtfamily.Text;
                string phone = txtphone.Text;
                string id = txtid.Text;
                x = new nobatdehi(name, familyname, id, work, phone, date, txtfilecode.Text,doctorname, chkeven.Checked, chkodd.Checked);
            }
            DateTime s = x.readandgetnobat(path);
            if (s == new DateTime(1, 1, 1, 1, 1, 1))
            {
                DialogResult res = MessageBox.Show("not have turn in this day do you want to set after this day", "settime", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (res == DialogResult.Yes)
                {
                    s = x.another();
                    txtresult.Text = s.ToString();
                }
            }
            else
                txtresult.Text = s.ToString();

        }

        private void groupBox1_BindingContextChanged(object sender, EventArgs e)
        {

        }
    }
}
