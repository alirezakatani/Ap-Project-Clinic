using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{
    public class paymentturn : Ipayment
    {
        public DateTime first { get; set; }
        public string doctorname { get; set; }
        public double money { get; set; }
        public int numberofpayment { get; set; }
        static List<paymentturn> payments = new List<paymentturn>();
        public paymentturn(string doc, double mon, int numpay, DateTime date)
        {
            doctorname = doc;
            money = mon;
            numberofpayment = numpay;
            first = date;

        }
        public paymentturn()
        {

        }
        public static void payalltoday(DateTime today)
        {
            payments = readandwritepayment.set();
           
       
            for (int i = 0; i < payments.Count; i++)
            {
               
                if (payments[i].first.DayOfYear == today.DayOfYear && payments[i].first.Year == today.Year && payments[i].numberofpayment > 0)
                {
                    string saveincomefile = rateform.getpath() + "\\income.txt";
                    string cost = payments[i].doctorname + "*" + payments[i].money + "\n";
                    System.IO.File.AppendAllText(saveincomefile, cost);
                    payments[i].first = payments[i].first.AddDays(30);
                    payments[i].numberofpayment--;
                    

                }
               

            }
            readandwritepayment.writelist(payments);
            

        }
    }
    public static class readandwritepayment
    {
        static string path = rateform.getpath() + "\\payment.txt";
        static List<paymentturn> payments = new List<paymentturn>();
        static List<Ipayment> payme = new List<Ipayment>();
        static List<Ipayment> todaypayme = new List<Ipayment>();

        public static void writeinfile(paymentturn pay)
        {
            string todaypays = pay.doctorname + '*' + pay.money + '*' + pay.numberofpayment + '*' + pay.first.ToString()+"\n";
            System.IO.File.AppendAllText(path, todaypays);
        }
        public static List<paymentturn> set()
        {
            payments.Clear();
            payme.Clear();
            todaypayme.Clear();
            string[] pays = System.IO.File.ReadAllLines(path);
            string[] perpays;
            for (int i = 0; i < pays.Length; i++)
            {
                perpays = pays[i].Split('*');
                paymentturn newpay = new paymentturn(perpays[0], Convert.ToDouble(perpays[1]), Convert.ToInt32(perpays[2]), Convert.ToDateTime(perpays[3]));
                payments.Add(newpay);
                payme.Add(newpay);
            }
            return payments;

        }
        public static List<Ipayment>get(DateTime time)
        {
            set();
            for (int i = 0; i < payme.Count; i++)
            {
                if (payme[i].first.DayOfYear == time.DayOfYear && payme[i].first.Year == time.Year)
                    todaypayme.Add(payme[i]);
            }
            return todaypayme;
        }
        public static void writelist(List<paymentturn> pay)
        {
            System.IO.File.Delete(path);
            for (int i = 0; i <pay.Count ; i++)
            {
                writeinfile(pay[i]);
            }
        }


    }

}
