using System;

namespace Ap_Project_Clinic_
{

    public static class finantial
    {
       
       
       
        public static double allincome{ get; set; }
        public static double allsalary{ get; set; }
        public static double allprofit { get; set; }
        public static double allmedcalex { get; set; }
        public static double getallincome()
        {
            allincome = 0;
            string saveincomefile = rateform.getpath() + "\\income.txt";
            string[] income = System.IO.File.ReadAllLines(saveincomefile);
            string[] income2;
        
            for (int i = 0;income[i]!=null ; i++)
            {
                income2 = income[i].Split('*');
                allincome += Convert.ToDouble(income2[1]);

            }

            return allincome;


        }
        public static double finalcheckout()
        {
            getallincome();
            allsalary = employes.getallsalary();
            allmedcalex = mediacal_expenses.getallexpences();
            allprofit = allincome - (allsalary + allmedcalex);
            if(allprofit<0)
            {
                return -1;
            }
            else
            {
                shareman.checkout();

            }
            return allprofit;
            


        }
        public static void set()
        {
            getallincome();
            finalcheckout();
        }
        
    }
}
