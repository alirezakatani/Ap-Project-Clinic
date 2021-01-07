using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{
    public partial class turns : Form
    {
        List<nobatdehi> todayturn = new List<nobatdehi>();
        nobatdehi x;
        public turns()
        {
            InitializeComponent();

        }
        static int i = 0;

        private void turns_Load(object sender, EventArgs e)
        {
            


        }
     
        public static string returncost(string work)
        {
            string paths = Application.StartupPath + "\\cost.txt";
            string[] cost = System.IO.File.ReadAllLines(paths);
            string[] costbase = cost[0].Split('*');

            if (work == "moayene")
            {
                return costbase[0];
            }
            else if (work == "tarmim1")
            {
                return costbase[1];
            }
            else if (work == "tarmim2")
            {
                return costbase[2];
            }
            else
            {
                return costbase[3];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtpayment.Text=="")
            {
                MessageBox.Show("not correct");
                return;

            }
            string saveincomefile = Application.StartupPath + "\\income.txt";
            string cost =txtdoctor.Text+"*"+txtpayment.Text+"\n";
            System.IO.File.AppendAllText(saveincomefile, cost);
            managenobat manage = new managenobat(x);
            manage.deletenobat(datenow.Value, txtfilecode.Text);
            foreach(Control c in panel1.Controls)
            {
                if(c is TextBox d)
                 d.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //todayturn = nobatdehi.getalltoday(datenow.Value);
            readandwrite read = new readandwrite();


            todayturn = read.getallnobatbasespeanddate(datenow.Value);
       
            getturn();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            i++;
            getturn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            getturn();
            

        }
        public void getturn()
        {
            if(i>=todayturn.Count||i<0)
            {
                MessageBox.Show("invalid turn.");
                return;
            }
             x = todayturn[i];
            if (x == null)
            {
                MessageBox.Show("wrong date");
            }
            else
            {
                txtname.Text = x.name;
                txtfamilyname.Text = x.familyname;
                txtphone.Text = x.phone;
                txtdoctor.Text = x.doctorname;
                txtfilecode.Text = x.fileid;
                txtturn.Text = Convert.ToString(x.shomarenobat);
                employes newemp = new employes(x.doctorname, "doctor");
                double money = Convert.ToDouble(returncost(x.work)) + Convert.ToDouble(readandwriteemp.getspecialsalary(newemp));
                txtpayment.Text = money.ToString();

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rateform rate = new rateform();
            rate.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            paymentturn pay = new paymentturn(txtdoctor.Text, Convert.ToDouble(txtpayment.Text)/ Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text),datenow.Value);
            readandwritepayment.writeinfile(pay);
            managenobat manage = new managenobat(x);
            manage.deletenobat(datenow.Value, txtfilecode.Text);
            foreach (Control c in panel1.Controls)
            {
                if(c is TextBox d)
                d.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            paymentturn.payalltoday(datenow.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                button8.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button8.Enabled = false;

            }
        }
        public double getbime()
        {
            bime nebim = readandwritebime.search(textBox2.Text);
            if(nebim!=null)
            {
                double newpay= (Convert.ToDouble(txtpayment.Text) * nebim.percent / 100); ;
                textBox3.Text = newpay.ToString();
                return newpay;
            }
            else
            {
                MessageBox.Show("sorry you have not bime");
                return 0;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                getbime();
            }

        }
    }
}
