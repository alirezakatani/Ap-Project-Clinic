using System;

namespace Ap_Project_Clinic_
{

    class employes : Ipay
    {
        public string name { get; set; }
        public string familyname { get; set; }
        public double salary { get; set; }
        public string idnumber { get; set; }
        public string account { get; set; }
        public string phone { get; set; }
        public string Job { get; set; }
        public double lastcash { get; set; }


        string path;
        public employes(string idnumber)
        {
            path = rateform.getpath() + "\\eminfo.txt";
            string[] allinform1 = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                if (personinform[4] == idnumber)
                {
                    name = personinform[0];
                    familyname = personinform[1];
                    salary = Convert.ToDouble(personinform[2]);
                    Job = personinform[3];
                    idnumber = personinform[4];
                    account = personinform[5];
                }

            }


        }
        public static double getallsalary()
        {
            Double allsalary = 0;
            string path = rateform.getpath() + "\\eminfo.txt";
            string[] emp = System.IO.File.ReadAllLines(path);
            string[] cost;
            foreach(string em in emp)
            {
                cost = em.Split('*');
                allsalary += Convert.ToDouble(cost[2]);
            }
            return allsalary;
        }
        public string checkoutv2()
        {
            string pathckeck = rateform.getpath() + "\\checkoutemployee.txt";
            string pathsaveaccount = rateform.getpath() + "\\account.txt";
            string[] allemp = System.IO.File.ReadAllLines(pathckeck);
            string[] empi;
            string[] allacc = System.IO.File.ReadAllLines(pathsaveaccount);
            string[] acci;
            string ret = "";
            for (int i = 0; allemp[i] != null; i++)
            {

                for (int j = 0; allacc[j] != null; j++)
                {
                    empi = allemp[i].Split('*');
                    string[] acc = allacc[i].Split('*');
                    if (acc[0] == empi[5])
                    {
                        acci = acc;
                        string check = "name:" + empi[0] + "*" + "familyname:" + empi[1] + "*" + "salary:" + empi[2] + "*" + "account:" + empi[5] + "*" + "Date:" + DateTime.Now;
                        string account = acci[0] + "*" + acci[1] + "*" + acci[2] + "*" + (Convert.ToInt32(acci[3]) + Convert.ToInt32(empi[2])) + "*" + DateTime.Now + "*" + empi[2];
                        System.IO.File.AppendAllText(pathckeck, check);
                        System.IO.File.AppendAllText(pathsaveaccount, account);
                        ret += check + "\n";

                    }

                }


            }
            return ret;
        }
        public string checkout()
        {
            string pathckeck = rateform.getpath() + "\\checkoutemployee.txt";
            string pathsaveaccount = rateform.getpath() + "\\account.txt";
            string check = "name:" + name + "*" + "familyname:" + familyname + "*" + "salary:" + salary + "*" + "account:" + account + "*" + "Date:" + DateTime.Now;
            string acc = account + '*' + name + '*' + familyname + '*' + lastcash + '*' + DateTime.Now + '*';
            System.IO.File.AppendAllText(pathckeck, check);
            System.IO.File.AppendAllText(pathsaveaccount, acc);
            return acc;




        }
        public static string getspecialsalary(string name, string work)
        {

            string pat = rateform.getpath() + "\\eminfo.txt";
            string[] emp = System.IO.File.ReadAllLines(pat);
            string[] cost;
            
            for (int i = 0; i<emp.Length; i++)
            {
                cost = emp[i].Split('*');
                if (name == cost[0] && work == cost[3])
                {
                    return cost[2];
                }


            }
            return null;

        }

        ////public string paymoney()
        //{
        //    string path = rateform.getpath() + "\\eminfo.txt";
        //    string pathsaveaccount = rateform.getpath() + "\\account.txt";
        //    string[] emp = System.IO.File.ReadAllLines(path);
        //    string[] cost;
        //    string[] accounts = System.IO.File.ReadAllLines(path);
        //    string[] acc;
        //    for (int i = 0; accounts[i] != null; i++)
        //    {
        //        acc = accounts[i].Split('*');
        //        for (int j = 0; emp[i]!=null; j++)
        //        {
        //            cost = emp[i].Split('*');
        //            if(acc[0]==cost[5])
        //            {

        //            }

        //        }




        //}
        //return null;



    }
}

