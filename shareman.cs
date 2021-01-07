using System;
using System.Collections.Generic;
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
        public DateTime datecheck { get; set; }
        public List<shareman> share = new List<shareman>();
        List<shareman> acc = new List<shareman>();
        string path = rateform.getpath() + @"\shareman.txt";
        string pathckeck = rateform.getpath() + "\\checkoutemployee.txt";
        public shareman(string idnumber)//read from file
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
            //        idnumber = personinform[4];
            //        account = personinform[5];
            //        lastcash = Convert.ToDouble(personinform[6]);
            //        this.idnumber = personinform[4];

            //    }

            //}
            share = readandwritesha.set();
            for (int i = 0; i < share.Count; i++)
            {
                if(share[i].idnumber==idnumber)
                {
                    name = share[i].name;
                    familyname = share[i].familyname;
                    salary = share[i].salary;
                    idnumber = share[i].idnumber;
                    account = share[i].account;
                    lastcash = share[i].lastcash;
                    this.idnumber = share[i].idnumber;

                }

            }

        }
        public shareman(string name, string familyname, string accountin, double lastcash, DateTime date)
        {
            this.name = name;
            this.familyname = familyname;
            this.account = accountin;
            this.lastcash = lastcash;
            datecheck = date;
        }

        public string checkout()
        {
            double allprofit = finantial.finalcheckout1();
            salary = (salary * allprofit) / 100;
            string ret = "";
            lastcash += salary;
            string check = "name:" + name + "*" + "familyname:" + familyname + "*" + "salary:" + salary + "*" + "account:" + account + "*" + "Date:" + DateTime.Now + "*" + "shareman" + "lastcash" + lastcash + "\n";
            System.IO.File.AppendAllText(pathckeck, check);
            ret += check + "\n";
            return ret;
        }




    }
    public static class readandwritesha
    {
        static string path = rateform.getpath() + @"\shareman.txt";
        static List<shareman> share = new List<shareman>();
        static List<Ipay> shaipay = new List<Ipay>();
        
        public static void writeinlist(List<Ipay> sha)
        {
            System.IO.File.Delete(path);
            string information = "";
            for (int i = 0; i < sha.Count; i++)
            {
                if (sha[i] is shareman share)
                    information += share.name + '*' + share.familyname + '*' + share.salary + '*' + share.salary + '*' + share.idnumber + '*' + share.account + '*' + share.lastcash + "\n";

            }
            System.IO.File.AppendAllText(path, information);
        }
        public static List<shareman> set()
        {

            share.Clear();
            shaipay.Clear();
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path);
            }
            string[] allinform1;
            try
            {
                allinform1 = System.IO.File.ReadAllLines(path);
                for (int i = 0; i < allinform1.Length; i++)
                {
                    string[] personinform = allinform1[i].Split('*');
                    share.Add(new shareman(personinform[4]));

                }

                return share;

            }
            catch
            {
                return share;
            }





        }
        public static shareman search(shareman sha)
        {
            set();
            for (int i = 0; i < share.Count; i++)
            {
                if (share[i].idnumber == sha.idnumber)
                    return sha;

            }
            return null;


        }
        public static List<Ipay>get()
        {
            set();
            for (int i = 0; i < share.Count; i++)
            {
                shaipay.Add(share[i]);

            }
            return shaipay;
        }
    }

}
