﻿using System;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class turns : Form
    {
        public turns()
        {
            InitializeComponent();

        }

        private void turns_Load(object sender, EventArgs e)
        {
            nobatdehi x = new nobatdehi(datenow.Value);
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
    }
}
