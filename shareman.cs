using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    class shareman
    {
        string name;
        string familyname;
       double interestpercent;
        string id;
        string account;
        public shareman(string id)
        {
            string path = rateform.getpath() + @"\shareman.txt";
          
            string [] allinform1 = System.IO.File.ReadAllLines(path);
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
        public void checkout(double allprofit)//needs to complete
        {

        }

    }
}
