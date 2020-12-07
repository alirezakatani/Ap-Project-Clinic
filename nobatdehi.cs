using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{
    class nobatdehi
    {
        string work;
        string name;
        string familyname;
        string idnumber;
        string phone;
        DateTime date;
        string path;
        int minute;
        string fileid;
        string doctorname;
        Boolean noteven;
        Boolean notodd;
        static int shomarenobat = 0;
        int minutemoayene = 10;
        int minutedarmansathi1 = 20;
        int minutedarmansathi2 = 30;
        int minutedarmanreshe = 40;
        public nobatdehi(string name, string familyname, string idnumber, string work, string phone, DateTime date,string fileid,string doctornames,Boolean ev,Boolean od)
        {
            this.work = work;
            this.name = name;
            this.doctorname = doctornames;
            this.noteven = ev;
            this.notodd = od;
            this.familyname = familyname;
            this.idnumber = idnumber;
            this.phone = phone;
            setminute();
            shomarenobat++;
            this.date = date;
            this.fileid = fileid;
        }
        public nobatdehi(DateTime date,string fileid,string work,string doctornames, Boolean ev, Boolean od)
        {
            this.date = date;
            this.fileid = fileid;
            this.doctorname = doctornames;
            this.noteven = ev;
            notodd = od;
            getfromfileid(fileid);
            this.work = work;
            setminute();
            shomarenobat++;
        }
        public void writeinfile(DateTime time)
        {

            this.date = time;
            string save = date.Year + "/" + date.Month + "/" + date.Day + "/" + '*' + date.TimeOfDay.ToString() + '*' + minute + '*' + work + '*' + name + '*' + familyname + '*' + idnumber + '*' + phone + '*' + shomarenobat + '\n';
            System.IO.File.AppendAllText(path + "\\nobat.txt", save);


        }
        public DateTime readandgetnobat(string path)
        {
            this.path = path;

            List<DateTime> timenoabt = new List<DateTime>();
            //if (shomarenobat <= 2)
            //{


            //    DateTime x;
            //    if(shomarenobat==1)
            //    {
            //         x= new DateTime(date.Year, date.Month, date.Day,15,0, 0);

            //    }

            //    else
            //    { string[] nb = System.IO.File.ReadAllLines(path + "\\nobat.txt");
            //        string[] ab = nb[0].Split('*');
            //         x = new DateTime(date.Year, date.Month, date.Day, 15, Convert.ToInt32(ab[2]), 0);

            //    }
            //    timenoabt.Add(x);
            //    writeinfile(x);
            //    return x;

            //}  
            string[] nobats = System.IO.File.ReadAllLines(path + "\\nobat.txt");
            string[] nob;
            int k = 0;
            foreach (string x in nobats)
            {
                nob = x.Split('*');
                string[] stime = nob[0].Split('/');
                string[] ttime = nob[1].Split(':');
                if (Convert.ToInt32(stime[0]) == date.Year && Convert.ToInt32(stime[1]) == date.Month && Convert.ToInt32(stime[2]) == date.Day)
                {
                    timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
                }
                k++;
            }
            if (timenoabt.Count == 0)
            {
                timenoabt.Add(new DateTime(date.Year, date.Month, date.Day, 15, 0, 0));
                writeinfile(new DateTime(date.Year, date.Month, date.Day, 15, 0, 0));
            }
            timenoabt.Sort();

            DateTime zs = new DateTime(timenoabt[timenoabt.Count - 1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day, timenoabt[timenoabt.Count - 1].Hour, timenoabt[timenoabt.Count - 1].Minute, 0);
            DateTime xs = new DateTime(timenoabt[timenoabt.Count - 1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day, 20, 0, 0);

            TimeSpan zx = xs - zs;
            if (zx.TotalMinutes > minute && zx.TotalMinutes > 0)
            {
                zs = zs.AddMinutes(minute);
                writeinfile(zs);
                return zs;

            }
            else
                return new DateTime(1, 1, 1, 1, 1, 1);//like flag


            return new DateTime(1, 1, 1, 1, 1, 1);

        }
        public void setminute()
        {
            if (work == "moayene")
                minute = minutemoayene;
            else if (work == "tarmim1")
                minute = minutedarmansathi1;
            else if (work == "tarmim2")
                minute = minutedarmansathi2;
            else if (work == "darmanreshe")
                minute = minutedarmanreshe;

        }
        public DateTime another()
        {


            List<DateTime> timenoabt = new List<DateTime>();

            string[] nobats = System.IO.File.ReadAllLines(path + "\\nobat.txt");
            string[] nob;
            int k = 0;
            foreach (string x in nobats)
            {
                nob = x.Split('*');
                string[] stime = nob[0].Split('/');
                string[] ttime = nob[1].Split(':');
                if (Convert.ToInt32(stime[2]) >= date.Day)
                {
                    timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
                }
                k++;
            }

            timenoabt.Sort();
            for (int i = 0; i < timenoabt.Count - 1; i++)
            {
                if (timenoabt[i].Day != timenoabt[i + 1].Day)
                {
                    DateTime zs = new DateTime(timenoabt[i].Year, timenoabt[i].Month, timenoabt[i].Day, timenoabt[i].Hour, timenoabt[i].Minute, 0);
                    DateTime xs = new DateTime(timenoabt[i].Year, timenoabt[i].Month, timenoabt[i].Day, 20, 0, 0);
                    TimeSpan zx = xs - zs;
                    if (zx.TotalMinutes > minute && zx.TotalMinutes > 0)
                    {
                        zs = zs.AddMinutes(minute);
                        writeinfile(zs);
                        return zs;

                    }
                    else
                        continue;


                }


            }
            DateTime ooop = new DateTime(timenoabt[timenoabt.Count - 1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day + 1, 15, 0, 0);
            writeinfile(ooop);
            return ooop;


        }
        public int getfromfileid(string fileid)
        {
            string[] allinform1 = System.IO.File.ReadAllLines(path + "\\nobat.txt");
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                if (personinform[8] == fileid)
                {
                    this.name = personinform[4];
                    this.familyname = personinform[5];
                    this.idnumber = personinform[6];
                    this.idnumber = personinform[7];
                    return 1;
                }
                  
            }
            return 0;
        }
  

    }
}


