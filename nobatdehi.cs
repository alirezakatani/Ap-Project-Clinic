using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{
    class nobatdehi
    {
        //string work;
        //string name;
        //string familyname;
        //string idnumber;
        //string phone;
        //DateTime date;
        //string path;
        //int minute;
        //string fileid;
        //string doctorname;
        //Boolean noteven;
        //Boolean notodd;
        public string name { get; set; }
        public string familyname { get; set; }
        public string phone { get; set; }
        public DateTime date { get; set; }
        public string work { get; set; }
        public string path { get; set; }
        public int minute { get; set; }
        public string idnumber { get; set; }
        public string fileid { get; set; }
        public string doctorname { get; set; }
        public Boolean noteven { get; set; }
        public Boolean notodd { get; set; }
        public int shomarenobat { get; set; }

        int minutemoayene = 10;
        int minutedarmansathi1 = 20;
        int minutedarmansathi2 = 30;
        int minutedarmanreshe = 40;
        public nobatdehi(string name, string familyname, string idnumber, string work, string phone, DateTime date, string fileid, string doctornames, Boolean ev, Boolean od)
        {
            path = rateform.getpath();
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
            this.fileid = idnumber;

        }
        public nobatdehi(DateTime date, string fileid, string work, string doctornames, Boolean ev, Boolean od)
        {
            this.idnumber = fileid;
            path = rateform.getpath();
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
     
        public static List<nobatdehi> getalltoday(DateTime date)//for Receiving turns
        {
           string path = rateform.getpath();
            List<nobatdehi> todayturn = new List<nobatdehi>();
            string[] allinform1 = System.IO.File.ReadAllLines(rateform.getpath() + "\\nobat.txt");
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                string[] dateofturn = personinform[0].Split('/');
                string[] timeofturn = personinform[1].Split(':');
                DateTime x = new DateTime(Convert.ToInt32(dateofturn[0]), Convert.ToInt32(dateofturn[1]), Convert.ToInt32(dateofturn[2]), 15, 0, 0);//nobathay har saat
                if (x.Year == date.Year && x.Month == date.Month && x.Day == date.Day)
                {
                    //this.minute = Convert.ToInt32(personinform[2]);
                    //this.work = personinform[3];
                    //this.name = personinform[4];
                    //this.familyname = personinform[5];
                    //this.idnumber = personinform[6];
                    //this.idnumber = personinform[7];
                    //this.fileid = personinform[8];
                    //this.date = date;
                    //return true;
                    nobatdehi no = new nobatdehi(date, personinform[8], personinform[3], personinform[11], Convert.ToBoolean(personinform[9]), Convert.ToBoolean(personinform[10]));
                    todayturn.Add(no);
                }

            }
            return todayturn;
            


        }
        public void writeinfile(DateTime time)
        {

            this.date = time;
            string save = date.Year + "/" + date.Month + "/" + date.Day + "/" + '*' + date.TimeOfDay.ToString() + '*' + minute + '*' + work + '*' + name + '*' + familyname + '*' + idnumber + '*' + phone + '*' + shomarenobat + '*' + noteven + '*' + notodd + '*' + doctorname + '\n';
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
            if(!System.IO.File.Exists(path + "\\nobat.txt"))
            {
                System.IO.File.Create(path + "\\nobat.txt");
            }
            string[] nobats = System.IO.File.ReadAllLines(path + "\\nobat.txt");
            string[] nob;
            int k = 0;
            foreach (string x in nobats)
            {
                nob = x.Split('*');
                string[] stime = nob[0].Split('/');
                string[] ttime = nob[1].Split(':');
                DateTime day = new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0);
                if (Convert.ToInt32(stime[0]) == date.Year && Convert.ToInt32(stime[1]) == date.Month && Convert.ToInt32(stime[2]) == date.Day && day.DayOfWeek != DayOfWeek.Friday&&nob[11]==doctorname)
                {
                    timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
                }
                k++;
            }
            if (timenoabt.Count == 0)
            {
                timenoabt.Add(new DateTime(date.Year, date.Month, date.Day, 15, 0, 0));
                writeinfile(new DateTime(date.Year, date.Month, date.Day, 15, 0, 0));
                return new DateTime(date.Year, date.Month, date.Day, 15, 0, 0);
            }
            timenoabt.Sort();
            for (int i = 0; i < timenoabt.Count-2; i++)
            {
                DateTime s1 = new DateTime(timenoabt[i].Year, timenoabt[i].Month, timenoabt[i].Day, timenoabt[i].Hour, timenoabt[i].Minute, 0);
                DateTime s2 = new DateTime(timenoabt[i+1].Year, timenoabt[i+1].Month, timenoabt[i+1].Day, timenoabt[i+1].Hour, timenoabt[i+1].Minute, 0);
                TimeSpan s3 = s2 - s1;
                if (s3.TotalMinutes > minute && s3.TotalMinutes > 0)
                {
                    s1 = s1.AddMinutes(minute);
                    writeinfile(s1);
                    return s1;
                }

            }

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


            //return new DateTime(1, 1, 1, 1, 1, 1);

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
                DateTime day = new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0);
                if (noteven == true)
                {
                    if (Convert.ToInt32(stime[2]) >= date.Day && day.DayOfWeek != DayOfWeek.Monday && day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Wednesday && day.DayOfWeek != DayOfWeek.Friday && nob[11] == doctorname)
                    {
                        timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
                    }
                }
                else
                {
                    if (Convert.ToInt32(stime[2]) >= date.Day && day.DayOfWeek != DayOfWeek.Sunday && day.DayOfWeek != DayOfWeek.Tuesday && day.DayOfWeek != DayOfWeek.Thursday && day.DayOfWeek != DayOfWeek.Friday && nob[11] == doctorname)
                    {
                        timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
                    }
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
                if (personinform[6] == fileid)
                {
                    this.name = personinform[4];
                    this.familyname = personinform[5];
                    this.idnumber = personinform[6];
                    this.phone = personinform[7];
                    this.shomarenobat = Convert.ToInt32(personinform[8]);
                    return 1;
                }

            }
            return 0;
        }
      
        
    }
}


