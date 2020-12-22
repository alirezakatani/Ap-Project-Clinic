using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{
    public partial class turns : Form
    {
        List<nobatdehi> todayturn = new List<nobatdehi>();
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
            string saveincomefile = Application.StartupPath + "\\income.txt";
            string cost =txtdoctor.Text+"*"+txtpayment.Text;
            System.IO.File.AppendAllText(saveincomefile, cost);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            todayturn = nobatdehi.getalltoday(datenow.Value);
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
            nobatdehi x = todayturn[i];
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
                 double money = Convert.ToDouble(returncost(x.work)) + Convert.ToDouble(employes.getspecialsalary(x.doctorname, "doctor"));
                 txtpayment.Text = money.ToString();

            }
            
        }

    }
}
