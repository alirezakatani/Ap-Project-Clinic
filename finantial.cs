using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{

    public static class finantial
    {


         static string saveincomefile = rateform.getpath() + "\\income.txt";
        public static double allincome { get; set; }
        public static double allsalary { get; set; }
        public static double allprofit { get; set; }
        public static double allmedcalex { get; set; }
        public static List<Ipay> pays = new List<Ipay>();
        public static double getallincome()
        {
            allincome = 0;
            
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
            for (int i = 0; i < income.Length; i++)
            {
                income2 = income[i].Split('*');
                allincome += Convert.ToDouble(income2[1])/2;

            }

            return allincome;


        }
        public static string finalcheckout()
        {
            
            getallincome();
            allsalary = readandwriteemp.getallsalary();
            allmedcalex = mediacal_expenses.getallexpences();
            string x = "";
            allprofit = allincome - (allsalary + allmedcalex);
            allprofit = allprofit ;
            if (allprofit < 0)
            {
                return null;
            }
            else
            {
                pays.Clear();
                string path = rateform.getpath() + @"\shareman.txt";
                string pathemp = rateform.getpath() + "\\eminfo.txt";
                string[] allinform1 = System.IO.File.ReadAllLines(path);
                string[] personinform;
                string[] allem = System.IO.File.ReadAllLines(pathemp);
                string[] eminfo;
                string [] payincome = System.IO.File.ReadAllLines(saveincomefile);
                string[] income;
                /*ist<Ipay> shareman = new List<Ipay>();*/
                for (int i = 0; i < allinform1.Length; i++)
                {
                    personinform = allinform1[i].Split('*');
                    //shareman.Add(new shareman(personinform[4]));
                    pays.Add(readandwritesha.search(new shareman(personinform[4])));

                }
                for (int i = 0; i < allem.Length; i++)
                {
                    eminfo = allem[i].Split('*');
                    //shareman.Add(new employes(eminfo[4]));
                    pays.Add(readandwriteemp.search(new employes(eminfo[4])));

                }
                for (int i = 0; i < pays.Count; i++)
                {
                     pays[i].checkout();

                }
                for (int i = 0; i <payincome.Length; i++)
                {
                    income = payincome[i].Split('*');
                    employes co = readandwriteemp.search(new employes(income[0],"doctor"));
                    
                    co.checksomeone();
                }
                readandwriteemp.writeinlist(pays);
                readandwritesha.writeinlist(pays);
            }

            return x;
        }
        public static List<Ipay> set()
        {
            getallincome();

            string x=finalcheckout();
            if (x == null)
                return null;
                
            return pays;
        }
        public static double finalcheckout1()
        {
            getallincome();
            allsalary = readandwriteemp.getallsalary();
            allmedcalex = mediacal_expenses.getallexpences();
            allprofit = allincome - (allsalary + allmedcalex);
            allprofit = allprofit;//sahm doctor
            return allprofit;
        }

    }
}
