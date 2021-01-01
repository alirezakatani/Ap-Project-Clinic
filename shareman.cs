using System;

namespace Ap_Project_Clinic_
{
    public class shareman : Ipay
    {
        public string name { get; set; }
        public string familyname { get; set; }
        public double salary { get; set; }//percent of share
        public string idnumber { get; set; }
        public string account { get; set; }
        public string phone { get; set; }
        public Double lastcash { get; set; }

        public shareman(string idnumber)
        {
            string path = rateform.getpath() + @"\shareman.txt";

            string[] allinform1 = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                if (personinform[5] == idnumber)
                {
                    name = personinform[0];
                    familyname = personinform[1];
                    salary = Convert.ToDouble(personinform[2]);
                    idnumber = personinform[4];
                    account = personinform[5];
                    lastcash = 0;

                }

            }
        }
        public string checkoutv2()
        {
            double allprofit = finantial.finalcheckout1();
            string path = rateform.getpath() + @"\shareman.txt";
            string pathsaveaccount = rateform.getpath() + "\\account.txt";
            string[] allinform1 = System.IO.File.ReadAllLines(path);
            string[] allacc = System.IO.File.ReadAllLines(pathsaveaccount);
            string[] acc;
            double salary = 0;
            string allpay = "";
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                salary = (Convert.ToDouble(personinform[2]) * allprofit) / 100;


                for (int j = 0; allacc[j] != null; j++)
                {
                    acc = allacc[j].Split('*');
                    if (personinform[5] == acc[2])
                    {

                        string pay = personinform[5] + '*' + personinform[0] + '*' + personinform[1] + '*' + (Convert.ToDouble(acc[3]) + salary).ToString() + '*' + DateTime.Now + '*' + "shareman";
                        System.IO.File.AppendAllText(pathsaveaccount, pay);
                        allpay += pay + "\n";

                    }
                }




            }

            return allpay;

        }
        public string checkout()
        {

            string pathsaveaccount = rateform.getpath() + "\\account.txt";
            lastcash += salary * finantial.allprofit / 100;
            string pay = account + '*' + name + '*' + familyname + '*' + lastcash + '*' + DateTime.Now + '*' + "shareman";
            System.IO.File.AppendAllText(pathsaveaccount, pay);
            return pay;

        }



    }
}
