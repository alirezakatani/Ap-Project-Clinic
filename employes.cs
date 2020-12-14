﻿using System;

namespace Ap_Project_Clinic_
{

    class employes
    {
        string name;
        string familyname;
        double salary;
        string Job;
        string id;
        string account;
        string path;
        public employes(string id)
        {
            path = rateform.getpath() + "\\eminfo.txt";
            string[] allinform1 = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                if (personinform[4] == id)
                {
                    name = personinform[0];
                    familyname = personinform[1];
                    salary = Convert.ToDouble(personinform[2]);
                    Job = personinform[3];
                    id = personinform[4];
                    account = personinform[5];
                }

            }


        }
        public double getallsalary()
        {
            Double allsalary = 0;
            path = rateform.getpath() + "\\eminfo.txt";
            string[] emp = System.IO.File.ReadAllLines(path);
            string[] cost;
            for (int i = 0; emp[i]!=null; i++)
            {
                cost = emp[i].Split('*');
                allsalary += Convert.ToDouble(cost[1]);
            }
            return allsalary;
        }
        public  static void Checkout()
        {
            string pathckeck = rateform.getpath() + "\\checkoutemployee.txt";
            string pathsaveaccount = rateform.getpath() + "\\account.txt";
            string[] allemp = System.IO.File.ReadAllLines(pathckeck);
            string[] empi;
            string []allacc= System.IO.File.ReadAllLines(pathsaveaccount);
            string[] acci;
            for (int i = 0; allemp[i] != null; i++)
            {
                empi = allemp[i].Split('*');
                acci = allacc[i].Split('*');
                string check = "name:" + empi[0] + "*" + "familyname:" + empi[1] + "*" + "salary:" + empi[2]+"*"+"account:"+empi[5]+"*"+"Date:"+DateTime.Now;
                string account= acci[0]+ "*" + acci[1] + "*" + acci[2] + "*" + (Convert.ToInt32(acci[3])+Convert.ToInt32(empi[2])) + "*" + DateTime.Now+"*"+empi[2];
                System.IO.File.AppendAllText(pathckeck, check);
                System.IO.File.AppendAllText(pathsaveaccount, account);
            }

        }

    }
}
