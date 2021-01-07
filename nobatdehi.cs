using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{
    //public class nobatdehi :Iperson
    //{
    //    //string work;
    //    //string name;
    //    //string familyname;
    //    //string idnumber;
    //    //string phone;
    //    //DateTime date;
    //    //string path;
    //    //int minute;
    //    //string fileid;
    //    //string doctorname;
    //    //Boolean noteven;
    //    //Boolean notodd;
    //    public string name { get; set; }
    //    public string familyname { get; set; }
    //    public string phone { get; set; }
    //    public DateTime date { get; set; }
    //    public string work { get; set; }
    //    public string path { get; set; }
    //    public int minute { get; set; }
    //    public string idnumber { get; set; }
    //    public string fileid { get; set; }
    //    public string doctorname { get; set; }
    //    public Boolean noteven { get; set; }
    //    public Boolean notodd { get; set; }
    //    public int shomarenobat { get; set; }
    //    List<DateTime> timenoabt = new List<DateTime>();

    //    int minutemoayene = 10;
    //    int minutedarmansathi1 = 20;
    //    int minutedarmansathi2 = 30;
    //    int minutedarmanreshe = 40;
    //    public nobatdehi(string name, string familyname, string idnumber, string work, string phone, DateTime date, string fileid, string doctornames, Boolean ev, Boolean od)
    //    {
    //        path = rateform.getpath();
    //        this.work = work;
    //        this.name = name;
    //        this.doctorname = doctornames;
    //        this.noteven = ev;
    //        this.notodd = od;
    //        this.familyname = familyname;
    //        this.idnumber = idnumber;
    //        this.phone = phone;
    //        setminute();
    //        shomarenobat++;
    //        this.date = date;
    //        this.fileid = idnumber;

    //    }
    //    public nobatdehi(DateTime date, string fileid, string work, string doctornames, Boolean ev, Boolean od)
    //    {
    //        this.idnumber = fileid;
    //        path = rateform.getpath();
    //        this.date = date;
    //        this.fileid = fileid;
    //        this.doctorname = doctornames;
    //        this.noteven = ev;
    //        notodd = od;
    //        getfromfileid(fileid);
    //        this.work = work;
    //        setminute();
    //        shomarenobat++;
    //    }
    //    public nobatdehi(string fileid)
    //    {
    //        getfromfileid(fileid);

    //    }

    //    public static List<nobatdehi> getalltoday(DateTime date)//for Receiving turns
    //    {
    //        string path = rateform.getpath();
    //        List<nobatdehi> todayturn = new List<nobatdehi>();
    //        string[] allinform1 = System.IO.File.ReadAllLines(rateform.getpath() + "\\nobat.txt");
    //        for (int i = 0; i < allinform1.Length; i++)
    //        {
    //            string[] personinform = allinform1[i].Split('*');
    //            string[] dateofturn = personinform[0].Split('/');
    //            string[] timeofturn = personinform[1].Split(':');
    //            DateTime x = new DateTime(Convert.ToInt32(dateofturn[0]), Convert.ToInt32(dateofturn[1]), Convert.ToInt32(dateofturn[2]), 15, 0, 0);//nobathay har saat
    //            if (x.Year == date.Year && x.Month == date.Month && x.Day == date.Day)
    //            {

    //                nobatdehi no = new nobatdehi(date, personinform[6], personinform[3], personinform[11], Convert.ToBoolean(personinform[9]), Convert.ToBoolean(personinform[10]));
    //                todayturn.Add(no);
    //            }

    //        }
    //        return todayturn;



    //    }

    //    public void writeinfile(DateTime time)
    //    {

    //        this.date = time;
    //        string save = date.Year + "/" + date.Month + "/" + date.Day + "/" + '*' + date.TimeOfDay.ToString() + '*' + minute + '*' + work + '*' + name + '*' + familyname + '*' + idnumber + '*' + phone + '*' + shomarenobat + '*' + noteven + '*' + notodd + '*' + doctorname + '\n';
    //        System.IO.File.AppendAllText(path + "\\nobat.txt", save);


    //    }
    //    public DateTime readandgetnobat(string path)
    //    {
    //        getallnobat(date);
    //        this.path = path;
    //        if (timenoabt.Count == 0)
    //        {
    //            timenoabt.Add(new DateTime(date.Year, date.Month, date.Day, 15, 0, 0));
    //            writeinfile(new DateTime(date.Year, date.Month, date.Day, 15, 0, 0));
    //            return new DateTime(date.Year, date.Month, date.Day, 15, 0, 0);
    //        }
    //        timenoabt.Sort();
    //        for (int i = 0; i < timenoabt.Count - 2; i++)
    //        {
    //            DateTime s1 = new DateTime(timenoabt[i].Year, timenoabt[i].Month, timenoabt[i].Day, timenoabt[i].Hour, timenoabt[i].Minute, 0);
    //            DateTime s2 = new DateTime(timenoabt[i + 1].Year, timenoabt[i + 1].Month, timenoabt[i + 1].Day, timenoabt[i + 1].Hour, timenoabt[i + 1].Minute, 0);
    //            TimeSpan s3 = s2 - s1;
    //            if (s3.TotalMinutes > minute && s3.TotalMinutes > 0)
    //            {
    //                s1 = s1.AddMinutes(minute);
    //                writeinfile(s1);
    //                return s1;
    //            }

    //        }

    //        DateTime zs = new DateTime(timenoabt[timenoabt.Count - 1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day, timenoabt[timenoabt.Count - 1].Hour, timenoabt[timenoabt.Count - 1].Minute, 0);
    //        DateTime xs = new DateTime(timenoabt[timenoabt.Count - 1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day, 20, 0, 0);
    //        TimeSpan zx = xs - zs;
    //        if (zx.TotalMinutes > minute && zx.TotalMinutes > 0)
    //        {
    //            zs = zs.AddMinutes(minute);
    //            writeinfile(zs);
    //            return zs;
    //        }
    //        else
    //            return new DateTime(1, 1, 1, 1, 1, 1);//like flag


    //        //return new DateTime(1, 1, 1, 1, 1, 1);

    //    }
    //    public void setminute()
    //    {
    //        if (work == "moayene")
    //            minute = minutemoayene;
    //        else if (work == "tarmim1")
    //            minute = minutedarmansathi1;
    //        else if (work == "tarmim2")
    //            minute = minutedarmansathi2;
    //        else if (work == "darmanreshe")
    //            minute = minutedarmanreshe;

    //    }
    //    public DateTime another()
    //    {


    //        List<DateTime> timenoabt = new List<DateTime>();

    //        string[] nobats = System.IO.File.ReadAllLines(path + "\\nobat.txt");
    //        string[] nob;
    //        int k = 0;
    //        foreach (string x in nobats)
    //        {
    //            nob = x.Split('*');
    //            string[] stime = nob[0].Split('/');
    //            string[] ttime = nob[1].Split(':');
    //            DateTime day = new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0);
    //            if (noteven == true)
    //            {
    //                if (Convert.ToInt32(stime[2]) >= date.Day && day.DayOfWeek != DayOfWeek.Monday && day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Wednesday && day.DayOfWeek != DayOfWeek.Friday && nob[11] == doctorname)
    //                {
    //                    timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
    //                }
    //            }
    //            else
    //            {
    //                if (Convert.ToInt32(stime[2]) >= date.Day && day.DayOfWeek != DayOfWeek.Sunday && day.DayOfWeek != DayOfWeek.Tuesday && day.DayOfWeek != DayOfWeek.Thursday && day.DayOfWeek != DayOfWeek.Friday && nob[11] == doctorname)
    //                {
    //                    timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
    //                }
    //            }

    //            k++;
    //        }
    //        timenoabt.Sort();
    //        for (int i = 0; i < timenoabt.Count - 1; i++)
    //        {
    //            if (timenoabt[i].Day != timenoabt[i + 1].Day)
    //            {
    //                DateTime zs = new DateTime(timenoabt[i].Year, timenoabt[i].Month, timenoabt[i].Day, timenoabt[i].Hour, timenoabt[i].Minute, 0);
    //                DateTime xs = new DateTime(timenoabt[i].Year, timenoabt[i].Month, timenoabt[i].Day, 20, 0, 0);
    //                TimeSpan zx = xs - zs;
    //                if (zx.TotalMinutes > minute && zx.TotalMinutes > 0)
    //                {
    //                    zs = zs.AddMinutes(minute);
    //                    writeinfile(zs);
    //                    return zs;
    //                }
    //                else
    //                    continue;
    //            }


    //        }
    //        DateTime ooop = new DateTime(timenoabt[timenoabt.Count - 1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day + 1, 15, 0, 0);
    //        writeinfile(ooop);
    //        return ooop;
    //    }
    //    public int getfromfileid(string fileid)
    //    {
    //        string[] allinform1 = System.IO.File.ReadAllLines(path + "\\nobat.txt");
    //        for (int i = 0; i < allinform1.Length; i++)
    //        {
    //            string[] personinform = allinform1[i].Split('*');
    //            string[] stime = personinform[0].Split('/');
    //            string[] ttime = personinform[1].Split(':');
    //            DateTime day = new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0);
    //            if (personinform[6] == fileid)
    //            {

    //                this.name = personinform[4];
    //                this.familyname = personinform[5];
    //                this.idnumber = personinform[6];
    //                this.phone = personinform[7];
    //                this.shomarenobat = Convert.ToInt32(personinform[8]);
    //                this.date = day;
    //                this.doctorname = personinform[11];
    //                this.fileid = personinform[6];
    //                this.noteven = Convert.ToBoolean(personinform[9]);
    //                this.notodd = Convert.ToBoolean(personinform[10]);
    //                this.minute = Convert.ToInt32(personinform[2]);
    //                this.work = personinform[3];
    //                return 1;
    //            }

    //        }
    //        return 0;
    //    }
    //    public void getallnobat(DateTime hist)//getallnobats
    //    {
    //        if (!System.IO.File.Exists(path + "\\nobat.txt"))
    //        {
    //            System.IO.File.Create(path + "\\nobat.txt");
    //        }
    //        string[] nobats = System.IO.File.ReadAllLines(path + "\\nobat.txt");
    //        string[] nob;
    //        int k = 0;
    //        foreach (string x in nobats)
    //        {
    //            nob = x.Split('*');
    //            string[] stime = nob[0].Split('/');
    //            string[] ttime = nob[1].Split(':');
    //            DateTime day = new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0);
    //            if (Convert.ToInt32(stime[0]) == date.Year && Convert.ToInt32(stime[1]) == date.Month && Convert.ToInt32(stime[2]) == date.Day && day.DayOfWeek != DayOfWeek.Friday && nob[11] == doctorname)
    //            {
    //                timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
    //            }
    //            k++;
    //        }


    //    }
    //    public DateTime getdate(string fid)
    //    {
    //        nobatdehi date = new nobatdehi(fid);
    //        return date.date;

    //    }
    //    public static string nobatdehiToString(nobatdehi nobat)
    //    {

    //        return nobat.date.Year + "/" + nobat.date.Month + "/" + nobat.date.Day + "/" + '*' + nobat.date.TimeOfDay.ToString() + '*' + nobat.minute + '*' + nobat.work + '*' + nobat.name + '*' + nobat.familyname + '*' + nobat.idnumber + '*' + nobat.phone + '*' + nobat.shomarenobat + '*' + nobat.noteven + '*' + nobat.notodd + '*' + nobat.doctorname + '\n';
    //    }
    //    public static nobatdehi StringTonobatdehi(string nobat)
    //    {
    //        string[] personinform = nobat.Split('*');
    //        nobatdehi nobats = new nobatdehi(personinform[6]);
    //        return nobats;
    //    }


    //}















    /// <summary>
    /// this is my second kind to do it;nobatdehi must uncomment;
    /// </summary>
    interface readandwritefromfile
    {

        List<DateTime> getallnobat(nobatdehi nobat);
        void writeinfile(nobatdehi nobat, List<DateTime> gets);
        void writeinfilebaselist(List<nobatdehi> newlist);
        List<nobatdehi> getallnobatbasespeficaation();
    }
    public class nobatdehi : Iturn
    {

        public string name { get; set; }
        public string familyname { get; set; }
        public string phone { get; set; }
        public DateTime date { get; set; }
        public string work { get; set; }
        public string path =rateform.getpath();
        public int minute { get; set; }
        public string idnumber { get; set; }
        public string fileid { get; set; }
        public string doctorname { get; set; }
        public Boolean noteven { get; set; }
        public Boolean notodd { get; set; }
        public int shomarenobat { get; set; }
        List<DateTime> timenoabt = new List<DateTime>();
        List<nobatdehi> nobat = new List<nobatdehi>();
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
        public nobatdehi(string fileid)
        {
         

            getfromfileid(fileid);

        }
        public nobatdehi()
        {
            
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

        public int getfromfileid(string fileid)
        {
            readandwrite read = new readandwrite();
            nobat = read.getallnobatbasespeficaation();
            this.name = name;
            this.familyname = familyname;
            this.phone = phone;
            return 0;
        }
        public static string nobatdehiToString(nobatdehi nobat)
        {

            return nobat.date.Year + "/" + nobat.date.Month + "/" + nobat.date.Day + "/" + '*' + nobat.date.TimeOfDay.ToString() + '*' + nobat.minute + '*' + nobat.work + '*' + nobat.name + '*' + nobat.familyname + '*' + nobat.idnumber + '*' + nobat.phone + '*' + nobat.shomarenobat + '*' + nobat.noteven + '*' + nobat.notodd + '*' + nobat.doctorname + '\n';
        }
        public static nobatdehi StringTonobatdehi(string nobat)
        {
            string[] personinform = nobat.Split('*');
            string[] daten = personinform[0].Split('/');
            string[] datm = personinform[1].Split(':');
            DateTime x = new DateTime(Convert.ToInt32(daten[0]), Convert.ToInt32(daten[1]), Convert.ToInt32(daten[2]), Convert.ToInt32(datm[0]), Convert.ToInt32(datm[1]), 0);
            nobatdehi nobats = new nobatdehi(personinform[4], personinform[5], personinform[6], personinform[3], personinform[7], x, personinform[6], personinform[11], Convert.ToBoolean(personinform[9]), Convert.ToBoolean(personinform[10])); 
            return nobats;
        }


    }
    public class managenobat
    {
        List<DateTime> timenoabt = new List<DateTime>();
        nobatdehi newnobat;
        List<nobatdehi> newlist;

        readandwrite s = new readandwrite();
        readandwrite read = new readandwrite();

        string path = rateform.getpath() + "\\nobat.txt";
        public managenobat(nobatdehi newnobat)
        {
            s.newnobat = newnobat;

            this.timenoabt = s.getallnobat(newnobat);
            this.newlist = read.getallnobatbasespeficaation();
            this.newnobat = newnobat;


        }
        public managenobat()
        {
            this.timenoabt = s.getallnobat(newnobat);
            this.newlist = read.getallnobatbasespeficaation();
        }
        public DateTime getnobat()
        {

            timenoabt = s.getallnobat(newnobat);
            if (timenoabt.Count == 0)
            {
                timenoabt.Add(new DateTime(newnobat.date.Year, newnobat.date.Month, newnobat.date.Day, 15, 0, 0));
                newnobat.date = new DateTime(newnobat.date.Year, newnobat.date.Month, newnobat.date.Day, 15, 0, 0);
                s.writeinfile(newnobat, timenoabt);
                return new DateTime(newnobat.date.Year, newnobat.date.Month, newnobat.date.Day, 15, 0, 0);
            }
            timenoabt.Sort();
            for (int i = 0; i <= timenoabt.Count - 2; i++)
            {
                DateTime s1 = new DateTime(timenoabt[i].Year, timenoabt[i].Month, timenoabt[i].Day, timenoabt[i].Hour, timenoabt[i].Minute, 0);
                DateTime s2 = new DateTime(timenoabt[i + 1].Year, timenoabt[i + 1].Month, timenoabt[i + 1].Day, timenoabt[i + 1].Hour, timenoabt[i + 1].Minute, 0);
                TimeSpan s3 = s2 - s1;
                if (s3.TotalMinutes > newnobat.minute && s3.TotalMinutes > 0)
                {
                    s1 = s1.AddMinutes(newnobat.minute);
                    newnobat.date = s1;
                    timenoabt.Add(newnobat.date);
                    s.writeinfile(newnobat, timenoabt);
                    return s1;
                }

            }

            DateTime zs = new DateTime(timenoabt[timenoabt.Count - 1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day, timenoabt[timenoabt.Count - 1].Hour, timenoabt[timenoabt.Count - 1].Minute, 0);
            DateTime xs = new DateTime(timenoabt[timenoabt.Count - 1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day, 20, 0, 0);
            TimeSpan zx = xs - zs;
            if (zx.TotalMinutes > newnobat.minute && zx.TotalMinutes > 0)
            {
                zs = zs.AddMinutes(newnobat.minute);
                newnobat.date = zs;
                timenoabt.Add(newnobat.date);
                s.writeinfile(newnobat, timenoabt);
                return zs;
            }
            else
                return new DateTime(1, 1, 1, 1, 1, 1);//like flag


            //return new DateTime(1, 1, 1, 1, 1, 1);

        }
        public Boolean deletenobat(DateTime dayofturn, string fid)
        {
            for (int i = 0; i < newlist.Count; i++)
            {
                if (newlist[i].date.Year == dayofturn.Year && newlist[i].date.Month == dayofturn.Month && newlist[i].date.Day == dayofturn.Day && newlist[i].idnumber == fid)
                {
                    s.writedeletednobatinfile(newlist[i]);
                    Boolean x = newlist.Remove(newlist[i]);
                    Console.WriteLine(x);
                    s.writeinfilebaselist(newlist);

                    return true;

                }

            }
            s.writeinfilebaselist(newlist);
            return false;

        }
        public DateTime another()
        {
            DateTime another;
            Boolean flag = true;
            int i = 0;
            while (flag)
            {
                i++;
                another = newnobat.date.AddDays(1);
                if (newnobat.noteven == true)
                {
                    if (another.DayOfWeek == DayOfWeek.Saturday || another.DayOfWeek == DayOfWeek.Monday || another.DayOfWeek == DayOfWeek.Wednesday)
                    {
                        another = another.AddDays(1);

                    }
                }
                else if (newnobat.notodd == true)
                {
                    if (another.DayOfWeek == DayOfWeek.Sunday || another.DayOfWeek == DayOfWeek.Tuesday || another.DayOfWeek == DayOfWeek.Thursday)
                    {
                        another = another.AddDays(1);

                    }

                }
                if (another.DayOfWeek == DayOfWeek.Friday)
                {
                    another = another.AddDays(1);
                }
                timenoabt = s.getalldatebaseonanotherday(another);
                if(timenoabt.Count==0)
                {
                    DateTime x = new DateTime(another.Year, another.Month, another.Day, 15, 0, 0);
                    newnobat.date = x;
                    s.writeinfile(newnobat, timenoabt);
                    return x;

                }
                DateTime zs = timenoabt[timenoabt.Count - 1];
                DateTime xs = new DateTime(timenoabt[timenoabt.Count-1].Year, timenoabt[timenoabt.Count - 1].Month, timenoabt[timenoabt.Count - 1].Day, 20, 0, 0);
                TimeSpan zx = xs - zs;
                if (zx.TotalMinutes > newnobat.minute && zx.TotalMinutes > 0)
                {
                    zs = zs.AddMinutes(newnobat.minute);
                    newnobat.date = zs;
                    timenoabt.Add(newnobat.date);
                    s.writeinfile(newnobat, timenoabt);
                   
                    flag = false;
                     return zs;
                }
                if (i > 200)
                    break;


            }
            return new DateTime(1, 1, 1, 1, 1, 1);


            
        }
        public DateTime getfreetime(DateTime date)
        {
            if (timenoabt.Count == 0)
            {
                DateTime xs = new DateTime(newnobat.date.Year, newnobat.date.Month, newnobat.date.Day, 15, 0, 0);
                return xs;
            }
              
            return timenoabt[timenoabt.Count - 1];

        }
    }
    public class readandwrite : readandwritefromfile
    {

        List<DateTime> timenoabt = new List<DateTime>();
        List<nobatdehi> newlist = new List<nobatdehi>();
        List<nobatdehi> newlist2 = new List<nobatdehi>();
        List<DateTime> timenoabt2 = new List<DateTime>();
        string path = rateform.getpath() + "\\nobat.txt";
        string deletepath = rateform.getpath() + "\\deletednobat.txt";
        //DateTime day;
        public nobatdehi newnobat { get; set; }
        public List<DateTime> getallnobat(nobatdehi nobat)//getallnobats
        {
            //string[] nobats = System.IO.File.ReadAllLines(path);
            //string[] nob;
            //newnobat = nobat;
            //if (!System.IO.File.Exists(path))
            //{

            //    return timenoabt;
            //}
            ////set();


            //foreach (string x in nobats)
            //{
            //    nob = x.Split('*');
            //    string[] stime = nob[0].Split('/');
            //    string[] ttime = nob[1].Split(':');
            //    day = new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0);
            //    if (Convert.ToInt32(stime[0]) == newnobat.date.Year && Convert.ToInt32(stime[1]) == newnobat.date.Month && Convert.ToInt32(stime[2]) == newnobat.date.Day && day.DayOfWeek != DayOfWeek.Friday && nob[11] == newnobat.doctorname)
            //    {
            //        timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
            //    }

            //}
            //return timenoabt;
            getandsetalldate();
            getallnobatbasespeficaation();

            newnobat = nobat;
            for (int i = 0; i < timenoabt.Count; i++)
            {

                if (timenoabt[i].Year == newnobat.date.Year && timenoabt[i].Month == newnobat.date.Month && timenoabt[i].Day == newnobat.date.Day && timenoabt[i].DayOfWeek != DayOfWeek.Friday && newlist[i].doctorname == newnobat.doctorname)
                {
                    timenoabt2.Add(timenoabt[i]);
                }

            }
            return timenoabt2;


        }
        public void writeinfile(nobatdehi nobat, List<DateTime> gets)
        {
            timenoabt = gets;
            newnobat = nobat;
            string save = nobatdehi.nobatdehiToString(newnobat);
            System.IO.File.AppendAllText(path, save);


        }
        public void writeinfilebaselist(List<nobatdehi> newlist)
        {

            //var dvfd = from person in newlist orderby person.date descending select person;

            System.IO.File.Delete(path);
            string save = "";
            for (int i = 0; i < newlist.Count; i++)
            {

                save += newlist[i].date.Year + "/" + newlist[i].date.Month + "/" + newlist[i].date.Day + "/" + '*' + newlist[i].date.TimeOfDay.ToString() + '*' + newlist[i].minute + '*' + newlist[i].work + '*' + newlist[i].name + '*' + newlist[i].familyname + '*' + newlist[i].idnumber + '*' + newlist[i].phone + '*' + newlist[i].shomarenobat + '*' + newlist[i].noteven + '*' + newlist[i].notodd + '*' + newlist[i].doctorname + '\n';

            }
            System.IO.File.AppendAllText(path, save);
        }
        public void writedeletednobatinfile(nobatdehi deleted)
        {
            string save = nobatdehi.nobatdehiToString(deleted);
            System.IO.File.AppendAllText(deletepath, save);

        }
        public List<nobatdehi> getallnobatbasespeficaation()
        {
            if(newlist.Count>0)
            {
                newlist.Clear();
                newlist2.Clear();
            }

                
            if (!System.IO.File.Exists(path))
            {
                return newlist;
            }
            if (newlist.Count > 0)
                newlist.Clear();
            string[] allinform1 = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < allinform1.Length; i++)
            {
                newlist.Add(nobatdehi.StringTonobatdehi(allinform1[i]));
            }
            return newlist;

        }
        public List<DateTime> getalldatebaseonanotherday(DateTime date)
        {
            getandsetalldate();
            getallnobatbasespeficaation();
            for (int i = 0; i < newlist.Count; i++)
            {
                if (newlist[i].date.Year == date.Year && date.Month == newlist[i].date.Month && date.Day == newlist[i].date.Day)
                {
                    timenoabt2.Add(newlist[i].date);
                }

            }
            return timenoabt2;
            //for (int i = 0; i < timenoabt.Count; i++)
            //{

            //    if (newnobat.noteven == true)
            //    {
            //        if (timenoabt[i].DayOfYear >= newnobat.date.DayOfYear && timenoabt[i].Year >= newnobat.date.Year&& timenoabt[i].DayOfWeek != DayOfWeek.Monday && timenoabt[i].DayOfWeek != DayOfWeek.Saturday && timenoabt[i].DayOfWeek != DayOfWeek.Wednesday && timenoabt[i].DayOfWeek != DayOfWeek.Friday && newlist[i].doctorname == newnobat.doctorname)
            //        {
            //            timenoabt2.Add(timenoabt[i]);
            //        }
            //    }
            //    else if(newnobat.notodd==true)
            //    {
            //        if (timenoabt[i].DayOfYear >= newnobat.date.DayOfYear && timenoabt[i].Year >= newnobat.date.Year && timenoabt[i].DayOfWeek != DayOfWeek.Sunday && timenoabt[i].DayOfWeek != DayOfWeek.Tuesday && timenoabt[i].DayOfWeek != DayOfWeek.Thursday && timenoabt[i].DayOfWeek != DayOfWeek.Friday && newlist[i].doctorname == newnobat.doctorname)
            //        {
            //            timenoabt2.Add(timenoabt[i]);
            //        }
            //    }
            //    else
            //    {
            //        if (timenoabt[i].DayOfYear > newnobat.date.DayOfYear && timenoabt[i].Year >= newnobat.date.Year && timenoabt[i].DayOfWeek != DayOfWeek.Friday && newlist[i].doctorname == newnobat.doctorname)
            //        {
            //            timenoabt2.Add(timenoabt[i]);
            //        }
            //    }
            //}

            //return timenoabt2;

        }
        public List<nobatdehi> getallnobatbasespeanddate(DateTime date)
        {
            getallnobatbasespeficaation();
            //string[] allinform1 = System.IO.File.ReadAllLines(path);
            //for (int i = 0; i < allinform1.Length; i++)
            //{
            //    string[] personinform = allinform1[i].Split('*');
            //    string[] dateofturn = personinform[0].Split('/');
            //    string[] timeofturn = personinform[1].Split(':');
            //    DateTime x = new DateTime(Convert.ToInt32(dateofturn[0]), Convert.ToInt32(dateofturn[1]), Convert.ToInt32(dateofturn[2]), Convert.ToInt32(timeofturn[0]), Convert.ToInt32(timeofturn[1]), Convert.ToInt32(timeofturn[2]));
            //    if (date.Year == x.Year && date.Month == x.Month && date.Day == x.Day)
            //    {
            //        newlist.Add(nobatdehi.StringTonobatdehi(allinform1[i]));
            //    }


            //}
            //return newlist;
            
            for (int i = 0; i < newlist.Count; i++)
            {
                if (newlist[i].date.Year == date.Year && date.Month == newlist[i].date.Month && date.Day == newlist[i].date.Day)
                {
                    newlist2.Add(newlist[i]);
                    
                }

            }
            return newlist2;

        }
        public List<nobatdehi> getlistofallturnofoneperson(string fileid)
        {

            getallnobatbasespeficaation();
            //string[] allinform1 = System.IO.File.ReadAllLines(path);
            //for (int i = 0; i < allinform1.Length; i++)
            //{
            //    string[] personinform = allinform1[i].Split('*');
            //    string[] dateofturn = personinform[0].Split('/');
            //    string[] timeofturn = personinform[1].Split(':');
            //    DateTime x = new DateTime(Convert.ToInt32(dateofturn[0]), Convert.ToInt32(dateofturn[1]), Convert.ToInt32(dateofturn[2]), Convert.ToInt32(timeofturn[0]), Convert.ToInt32(timeofturn[1]), Convert.ToInt32(timeofturn[2]));
            //    if (personinform[6] == fileid)
            //    {
            //        newlist.Add(nobatdehi.StringTonobatdehi(allinform1[i]));
            //    }


            //}
            //return newlist;
            for (int i = 0; i < newlist.Count; i++)
            {
                if (newlist[i].fileid == fileid)
                {
                    newlist2.Add(newlist[i]);
                }
            }

            return newlist2;

        }
        public List<DateTime> getandsetalldate()
        {
            //if (timenoabt.Count > 0)
            //{
            //    timenoabt.Clear();
            //    timenoabt2.Clear();
            //}
            //string[] nobats = System.IO.File.ReadAllLines(path);
            //string[] nob;
            //if (!System.IO.File.Exists(path))
            //{
            //    return timenoabt;
            //}
            ////set();


            //foreach (string x in nobats)
            //{
            //    nob = x.Split('*');
            //    string[] stime = nob[0].Split('/');
            //    string[] ttime = nob[1].Split(':');
            //    timenoabt.Add(new DateTime(Convert.ToInt32(stime[0]), Convert.ToInt32(stime[1]), Convert.ToInt32(stime[2]), Convert.ToInt32(ttime[0]), Convert.ToInt32(ttime[1]), 0));
            //}
            //return timenoabt;
             getallnobatbasespeficaation();
            if (timenoabt.Count > 0)
            {
                timenoabt.Clear();
                timenoabt2.Clear();
            }
        
            if (!System.IO.File.Exists(path))
            {
                return timenoabt;
            }
           
            for (int i = 0; i < newlist.Count; i++)
            {
                timenoabt.Add(newlist[i].date);

            }
            return timenoabt;


        }
        public List<nobatdehi> getlistofalldeltedturn(string fileid)
        {
            string temppath = path;
            path = deletepath;
            newlist2 = getlistofallturnofoneperson(fileid);
            path = temppath;
            return newlist2;
        }


    }











































    //    public class nobatdehis
    //    {
    //        public string name { get; set; }
    //        public string familyname { get; set; }
    //        public string phone { get; set; }
    //        public DateTime date { get; set; }
    //        public string work { get; set; }
    //        public string path { get; set; }
    //        public int minute { get; set; }
    //        public string idnumber { get; set; }
    //        public string fileid { get; set; }
    //        public string doctorname { get; set; }
    //        public Boolean noteven { get; set; }
    //        public Boolean notodd { get; set; }
    //        public int shomarenobat { get; set; }
    //        public static string nobatdehiToString(nobatdehis nobat)
    //        {
    //            return nobat.date.Date.ToString()+'*' + nobat.minute + '*' + nobat.work + '*' + nobat.name + '*' + nobat.familyname + '*' + nobat.idnumber + '*' + nobat.phone + '*' + nobat.shomarenobat + '*' + nobat.noteven + '*' + nobat.notodd + '*' + nobat.doctorname + '\n';
    //        }

    //        public static nobatdehis StringTonobatdehi(string nobat)
    //        {
    //            string[] personinform = nobat.Split('*');
    //            nobatdehis nobats = new nobatdehis
    //            {
    //                name = personinform[4],
    //            familyname = personinform[5],
    //            idnumber = personinform[6],
    //            phone = personinform[7],
    //            shomarenobat = Convert.ToInt32(personinform[8]),
    //            date =Convert.ToDateTime(personinform[0]),
    //            doctorname = personinform[11],
    //            fileid = personinform[6],
    //            noteven = Convert.ToBoolean(personinform[9]),
    //            notodd = Convert.ToBoolean(personinform[10]),
    //            minute = Convert.ToInt32(personinform[2]),
    //            work = personinform[3],
    //        };
    //            return nobats;
    //        }
    //}
    //    public interface ISaveLoadManagenobatdehis
    //    {
    //        void SaveListToFile(string filePath, List<nobatdehis> appointmentList);
    //       List<nobatdehis> ReadListFromFile(string filePath);


    //    }
    //    public class Managenobatdehis
    //    {
    //        private readonly string _filePath = rateform.getpath() + "\\nobat.txt";
    //        private List<nobatdehi> nobatlist { get; set; }
    //        private readonly ISaveLoadManagenobatdehis _saveLoader;

    //        public Managenobatdehis(List<nobatdehi>nobatlist,)
    //        {

    //        }
    //        public Managenobatdehis( ISaveLoadManagenobatdehis saveLoader)
    //        {
    //            _saveLoader = saveLoader;
    //            nobatlist = new List<nobatdehi>();
    //            if (!File.Exists(_filePath))
    //                File.Create(_filePath).Close();
    //            else
    //                nobatlist = _saveLoader.ReadListFromFile(_filePath);
    //        }


    //        public void Addnobatedehis(nobatdehis nobat)
    //        {
    //            nobatlist.Add(nobat);
    //            _saveLoader.SaveListToFile(_filePath, nobatlist);
    //        }

    //        public void Removenobat(nobatdehis appointment)
    //        {
    //            nobatlist.Remove(appointment);
    //            _saveLoader.SaveListToFile(_filePath, nobatlist);
    //        }

    //        public void PrintAllnobat()
    //        {
    //            foreach (var nobat in nobatlist)
    //            {
    //                Console.WriteLine(nobatdehis.nobatdehiToString(nobat));
    //            }
    //        }



    //    }
    //    public class SaveLoadManageAppointments_WriteReadAll : ISaveLoadManagenobatdehis
    //    {
    //        public void SaveListToFile(string filePath, List<nobatdehis> nobatdehilist)
    //        {
    //            string content = "";
    //            foreach (var nobat in nobatdehilist)
    //            {
    //                content += nobatdehis.nobatdehiToString(nobat) + "\n";
    //            }
    //            File.WriteAllText(filePath, content);
    //        }

    //        public List<nobatdehis> ReadListFromFile(string filePath)
    //        {
    //            List<nobatdehis> nobatdehisList = new List<nobatdehis>();
    //            string[] nobatText = File.ReadAllLines(filePath);
    //            //appointmentList.Clear();
    //            foreach (var line in nobatText)
    //            {
    //                nobatdehisList.Add(nobatdehis.StringTonobatdehi(line));
    //            }
    //            return nobatdehisList;
    //        }
    //    }
}


