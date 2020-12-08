using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string path = rateform.getpath() + "\\eminfo.txt";
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

    }
}
