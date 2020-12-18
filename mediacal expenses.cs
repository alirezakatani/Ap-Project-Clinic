using System;



namespace Ap_Project_Clinic_
{

    class mediacal_expenses
    {
        string paths =rateform.getpath()+ "\\medicalexpnses.txt";
        public void getallcost()
        {
            string[] cost = System.IO.File.ReadAllLines(paths);
        }
        public void deleteallmounthly()
        {
            System.IO.File.WriteAllText(paths, String.Empty);
        }
        public static double getallexpences()
        {
            string paths = rateform.getpath()+ "\\medicalexpnses.txt";
            string[] expen = System.IO.File.ReadAllLines(paths);
            string[] cost;
            double costs = 0;
            int i = 0;
            while(expen[i]!=null)
            {
                cost = expen[i].Split('*');
                costs += Convert.ToDouble(cost[1]);
                i++;

                
            }
            return costs;
        }



    }
}
