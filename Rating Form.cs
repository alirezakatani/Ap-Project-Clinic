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


        }

        private void groupBox1_BindingContextChanged(object sender, EventArgs e)
        {
            foreach (Control co in doctorform.Controls)
            {
                co.Enabled = false;
            }
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

        private void btnratings_Click(object sender, EventArgs e)
        {
            if (!chkrestrictions.Checked)
            {
                chkodd.Checked = false;
                chkeven.Checked = false;
            }
            DateTime date = ratetime.Value;
            nobatdehi x;
            string work = "";
            string doctorname = "";
            if (chkeven.Checked == true)
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Monday || date.DayOfWeek == DayOfWeek.Wednesday)
                {
                    MessageBox.Show("please inter true date,this date is " + date.DayOfWeek + " and isnt odd");
                    return;
                }
            }
            else if(chkodd.Checked==true)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Tuesday || date.DayOfWeek == DayOfWeek.Thursday)
                {
                    MessageBox.Show("please inter true date,this date is " + date.DayOfWeek + " and isnt even");
                    return;
                }

            }
            if(date.DayOfWeek==DayOfWeek.Friday)
            {
                MessageBox.Show("its closed in fridays");
                return;
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
                x = new nobatdehi(date, txtfilecode.Text, work, doctorname, chkeven.Checked, chkodd.Checked);
            }
            else
            {
                path = Application.StartupPath;
                string name = txtname.Text;
                string familyname = txtfamily.Text;
                string phone = txtphone.Text;
                string id = txtfilecode.Text;
                x = new nobatdehi(name, familyname, id, work, phone, date, txtfilecode.Text, doctorname, chkeven.Checked, chkodd.Checked);
            }
            //DateTime s = x.readandgetnobat(path);
            managenobat manage = new managenobat(x);
            DateTime s = manage.getnobat();
            //DateTime s = 
            if (s == new DateTime(1, 1, 1, 1, 1, 1))
            {
                DialogResult res = MessageBox.Show("not have turn in this day do you want to set after this day", "settime", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (res == DialogResult.Yes)
                {
                    //s = x.another();
                    s = manage.another();
                    txtresult.Text = s.AddMinutes(+(double)x.minute).ToString();
                    txtfrom.Text = s.ToString() + " " + s.DayOfWeek;
                }
            }
            else
            {
               txtresult.Text=s.AddMinutes(+(double)x.minute).ToString();
txtfrom.Text = s.ToString() + " " + s.DayOfWeek;
            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (chknewpatient.Checked)
                infopanel.Enabled = true;
            else
                infopanel.Enabled = false;

        }

        private void infopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkhaveid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkhaveid.Checked == true)
                txtpatientid.Enabled = true;
            else
                txtpatientid.Enabled = false;

        }

        private void rb1serface_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1_BindingContextChanged(null, null);
        }

        private void rbroot_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1_BindingContextChanged(null, null);
        }

        private void rbsurface2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1_BindingContextChanged(null, null);
        }

        private void rbExamination_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1_BindingContextChanged(null, null);
        }

        private void chkrestrictions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkrestrictions.Checked)
            {
                chkodd.Enabled = true;
                chkeven.Enabled = true;
            }
            else
            {
                chkodd.Enabled = false;
                chkeven.Enabled = false;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in infopanel.Controls)
            {
                c.Text = "";
            }
            txtfilecode.Text = "";
            txtpatientid.Text = "";
            foreach (Control cont in groupBox2.Controls)
            {
                if (cont is CheckBox cb)
                    cb.Checked = false;
                if (cont is RadioButton cr)
                    cr.Checked = false;

            }
            foreach (Control cont in groupBox3.Controls)
            {
                if (cont is CheckBox cb)
                    cb.Checked = false;
                if (cont is RadioButton cr)
                    cr.Checked = false;

            }

        }
        //public void getnewturn(nobatdehi nobats)
        //{


        //}
    }
}
