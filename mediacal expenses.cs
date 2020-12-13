using System;



namespace Ap_Project_Clinic_
{

    class mediacal_expenses
    {
        string paths = "\\medicalexpnses.txt";
        public void getallcost()
        {
            string[] cost = System.IO.File.ReadAllLines(paths);
        }
        private void deleteallmounthly()
        {
            System.IO.File.WriteAllText(paths, String.Empty);
        }



    }
}
