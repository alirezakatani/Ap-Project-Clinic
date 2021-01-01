using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{

    public static class finantial
    {



        public static double allincome { get; set; }
        public static double allsalary { get; set; }
        public static double allprofit { get; set; }
        public static double allmedcalex { get; set; }
        public static double getallincome()
        {
            allincome = 0;
            string saveincomefile = rateform.getpath() + "\\income.txt";
            string[] income = null;
            try
            {
                income = System.IO.File.ReadAllLines(saveincomefile);
            }
            catch (Exception e)
            {
                return 0;


            }

            string[] income2;


            for (int i = 0; income[i] != null; i++)
            {
                income2 = income[i].Split('*');
                allincome += Convert.ToDouble(income2[1]);

            }

            return allincome;


        }
        public static string finalcheckout()
        {
            getallincome();
            allsalary = employes.getallsalary();
            allmedcalex = mediacal_expenses.getallexpences();
            string x = "";
            allprofit = allincome - (allsalary + allmedcalex);
            if (allprofit < 0)
            {
                return null;
            }
            else
            {
                string path = rateform.getpath() + @"\shareman.txt";
                string pathemp = rateform.getpath() + "\\eminfo.txt";
                string[] allinform1 = System.IO.File.ReadAllLines(path);
                string[] personinform;
                string[] allem = System.IO.File.ReadAllLines(pathemp);
                string[] eminfo;

                List<Ipay> shareman = new List<Ipay>();
                for (int i = 0; allinform1[i] != null; i++)
                {
                    personinform = allinform1[i].Split('*');
                    shareman.Add(new shareman(personinform[4]));

                }
                for (int i = 0; allem[i] != null; i++)
                {
                    eminfo = allem[i].Split('*');
                    shareman.Add(new employes(eminfo[4]));

                }
                for (int i = 0; i < shareman.Count; i++)
                {
                    x += shareman[i].checkout() + "\n";

                }



            }

            return x;


        }
        public static void set()
        {
            getallincome();
            finalcheckout();
        }
        public static double finalcheckout1()
        {
            getallincome();
            allsalary = employes.getallsalary();
            allmedcalex = mediacal_expenses.getallexpences();
            allprofit = allincome - (allsalary + allmedcalex);
            return allprofit;

        }
    }
}
