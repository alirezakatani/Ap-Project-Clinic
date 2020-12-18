using System;

namespace Ap_Project_Clinic_
{
    public class shareman
    {
        string name;
        string familyname;
        double interestpercent;
        string id;
        string account;
        public shareman(string id)
        {
            string path = rateform.getpath() + @"\shareman.txt";

            string[] allinform1 = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                if (personinform[5] == id)
                {
                    name = personinform[0];
                    familyname = personinform[1];
                    interestpercent = Convert.ToDouble(personinform[2]);
                    id = personinform[4];
                    account = personinform[5];

                }

            }
        }
        public static string checkout()//needs to complete
        {
            double allprofit = finantial.finalcheckout();
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

                        string pay = personinform[5] + "*" + personinform[0] + "*" + personinform[1] + '*' + (Convert.ToDouble(acc[3]) + salary).ToString() + '*' + DateTime.Now + '*' + "shareman";
                        System.IO.File.AppendAllText(pathsaveaccount, pay);
                        allpay += pay + "\n";

                    }
                }




            }

            return allpay;

        }



    }
}
