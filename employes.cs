using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{

    public class employes : Ipay
    {
        public string name { get; set; }
        public string familyname { get; set; }
        public double salary { get; set; }
        public string idnumber { get; set; }
        public string account { get; set; }
        public string phone { get; set; }
        public string Job { get; set; }
        public double lastcash { get; set; }
        public DateTime datecheck { get; set; }
        //static List<employes> empsta = new List<employes>();
        List<employes> empp = new List<employes>();
        static List<employes> accsta = new List<employes>();
        string pathckeck = rateform.getpath() + "\\checkoutemployee.txt";
        string path = rateform.getpath() + "\\eminfo.txt";
        public employes(string idnumber)
        {

            //string[] allinform1 = System.IO.File.ReadAllLines(path);
            //for (int i = 0; i < allinform1.Length; i++)
            //{
            //    string[] personinform = allinform1[i].Split('*');
            //    if (personinform[4] == idnumber)
            //    {
            //        name = personinform[0];
            //        familyname = personinform[1];
            //        salary = Convert.ToDouble(personinform[2]);
            //        Job = personinform[3];
            //        this.idnumber = personinform[4];
            //        account = personinform[5];
            //        this.lastcash = Convert.ToDouble(personinform[6]);
            //    }

            //}
            empp = readandwriteemp.set();
            for (int i = 0; i < empp.Count; i++)
            {
                if(empp[i].idnumber==idnumber)
                {
                    name = empp[i].name;
                    familyname = empp[i].familyname;
                    salary = empp[i].salary;
                    Job = empp[i].Job;
                    this.idnumber = empp[i].idnumber;
                    account = empp[i].account;
                    this.lastcash = empp[i].lastcash;
                    phone = empp[i].phone;
                    datecheck = empp[i].datecheck;

                }

            }


        }
        public employes(string name, string familyname, string accountin, double lastcash, DateTime date)
        {
            this.name = name;
            this.familyname = familyname;
            this.account = accountin;
            this.lastcash = lastcash;
            datecheck = date;
        }
        public employes(string named, string job)
        {
            //string[] allinform1 = System.IO.File.ReadAllLines(path);
            //for (int i = 0; i < allinform1.Length; i++)
            //{
            //    string[] personinform = allinform1[i].Split('*');
            //    if (personinform[0] == named && personinform[3] == job)
            //    {
            //        name = personinform[0];
            //        familyname = personinform[1];
            //        salary = Convert.ToDouble(personinform[2]);
            //        Job = personinform[3];
            //        idnumber = personinform[4];
            //        account = personinform[5];
            //        this.lastcash = Convert.ToDouble(personinform[6]);
            //    }

            //}
            empp = readandwriteemp.set();
            for (int i = 0; i < empp.Count; i++)
            {
                if (empp[i].name == named&&empp[i].Job==job)
                {
                    name = empp[i].name;
                    familyname = empp[i].familyname;
                    salary = empp[i].salary;
                    Job = empp[i].Job;
                    this.idnumber = empp[i].idnumber;
                    account = empp[i].account;
                    this.lastcash = empp[i].lastcash;
                    phone = empp[i].phone;
                    datecheck = empp[i].datecheck;

                }

            }


        }
        public employes(string name, string familyname, string accountin, double lastcash, double salary, string idnumber,string job)
        {
            this.name = name;
            this.familyname = familyname;
            this.account = accountin;
            this.lastcash = lastcash;
            this.salary = salary;
            this.idnumber = idnumber;
            this.Job = job;

        }


        public string checkout()
        {
            string ret = "";
            lastcash += salary;
            string check = "name:" + name + "*" + "familyname:" + familyname + "*" + "salary:" + salary + "*" + "account:" + account + "*" + "Date:" + DateTime.Now + "*" + "employee" + "*" + Job+"lastcash" + lastcash+"\n";
            System.IO.File.AppendAllText(pathckeck, check);
            ret += check + "\n";
            return ret;
        }

       
        public void checksomeone()
        {

            lastcash += salary / 2;
            string check = "name:" + name + "*" + "familyname:" + familyname + "*" + "salary:" + salary + "*" + "account:" + account + "*" + "Date:" + DateTime.Now + "*" + "employee" + "*" + Job + "\n";
            System.IO.File.AppendAllText(pathckeck, check);

        }

        
    }
    static class readandwriteemp
    {
        static List<employes> empp = new List<employes>();
        static List<Ipay> empipay = new List<Ipay>();
        static string path = rateform.getpath() + "\\eminfo.txt";
        public static List<employes> set()
        {
            empipay.Clear();
            empp.Clear();
            string[] emp = System.IO.File.ReadAllLines(path);
            string[] cost;
            foreach (string em in emp)
            {
                cost = em.Split('*');
                empp.Add(new employes(cost[0],cost[1],cost[5],Convert.ToDouble(cost[6]),Convert.ToDouble(cost[2]),cost[4],cost[3]));
            }
          
            return empp;

        }
        public static void writeinlist(List<Ipay> cpp)
        {
            System.IO.File.Delete(path);
            string eminfo = "";
            for (int i = 0; i < cpp.Count; i++)
            {
                if(cpp[i] is employes emp)
                 eminfo += emp.name + '*' + emp.familyname + '*' + emp.salary + '*' + emp.Job + '*' + emp.idnumber + '*' + emp.account + '*' + emp.lastcash + "\n";
               
            }
            System.IO.File.AppendAllText(path, eminfo);
           
        }
        public static string getspecialsalary(employes cm)
        {

            set();
            for (int i = 0; i < empp.Count; i++)
            {

                if (cm.name == empp[i].name && cm.Job == empp[i].Job)
                {
                    return Convert.ToString(empp[i].salary);
                }


            }
            return null;

        }
        public static double getallsalary()
        {
            set();
            double allsalery = 0;
       
          
            for (int i = 0; i < empp.Count; i++)
            {
                allsalery += empp[i].salary;

            }
            return allsalery;
          

        
        }
        public static employes search(employes sha)
        {
            set();
            for (int i = 0; i < empp.Count; i++)
            {
                if (empp[i].idnumber == sha.idnumber)
                    return empp[i];

            }
            return null;


        }
        public static List<Ipay> getall()
        {
            set();
            for (int i = 0; i < empp.Count; i++)
            {
                empipay.Add(empp[i]);
            }
            return empipay;
        }

    }
}

