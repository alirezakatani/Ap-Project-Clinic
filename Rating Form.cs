using System;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class rateform : Form
    {

        string path = Application.StartupPath;
        public rateform()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime date = ratetime.Value;
            nobatdehi x;
            string work = "";
            string doctorname = "";
            if(chkeven.Checked==true)
            {
                if(date.DayOfWeek!=DayOfWeek.Saturday&& date.DayOfWeek != DayOfWeek.Monday&& date.DayOfWeek != DayOfWeek.Wednesday)
                {
                    MessageBox.Show("please inter true date,this date is " + date.DayOfWeek + " and isnt odd");
                }
            }
            else
            {
                if (date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Tuesday && date.DayOfWeek != DayOfWeek.Thursday)
                {
                    MessageBox.Show("please inter true date,this date is " + date.DayOfWeek + " and isnt even");
                }

            }
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
                txtresult.Text = s.ToString()+" "+s.DayOfWeek;

        }

        private void groupBox1_BindingContextChanged(object sender, EventArgs e)
        {
            doctorform.Enabled = false;
            if (rbExamination.Checked == true)
            {
                cbexam.Enabled = true;
            }
            else if (rb1serface.Checked == true)
            {
                cbsu1.Enabled = true;
            }

            else if (rbsurface2.Checked == true)
            {
                cbsu2.Enabled = true;

            }
            else if (rbroot.Checked == true)
            {
                cbroot.Enabled = true;
            }

        }
        public static string getpath()
        {
            return Application.StartupPath;
        }
        //public void getnewturn(nobatdehi nobats)
        //{


        //}
    }
}
