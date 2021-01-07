using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{

    class bime : IBime
    {
        public string name { get; set; }
        public string familyname { get; set; }
        public string id { get; set; }
        public double percent { get; set; }
        public bime(string name,string familyname,string id,double percent)
        {
            this.name = name;
            this.familyname = familyname;
            this.id = id;
            this.percent = percent;
        }

    }
    static class readandwritebime
    {
        static List<bime> allbime = new List<bime>();
        static List<IBime> allibime = new List<IBime>();
        static string path = rateform.getpath() + "\\bime.txt";
        public static List<bime> set()
        {
            allbime.Clear();
            allibime.Clear();
            try
            {
                string[] allbim = System.IO.File.ReadAllLines(path);
                string[] bime;
                for (int i = 0; i < allbim.Length; i++)
                {
                    bime = allbim[i].Split('*');
                    allbime.Add(new bime(bime[0], bime[1], bime[2],Convert.ToDouble(bime[3])));
              

                }
                return allbime;
            }
            catch
            {
                return allbime;
            }
        }
        public static void writeone(bime bime)
        {
            string save = bime.name + '*' + bime.familyname + '*' + bime.id + '*' + bime.percent+"\n";
            System.IO.File.AppendAllText(path, save);

        }
        public static bime search(string id)
        {
            set();
            for (int i = 0; i < allbime.Count; i++)
            {
                if(allbime[i].id==id)
                {
                    return allbime[i];
                }

            }
            return null;

        }
        public static List<IBime>get()
        {
            set();
            for (int i = 0; i < allbime.Count; i++)
            {
                allibime.Add(allbime[i]);

            }
            return allibime;
        }
    }
}
