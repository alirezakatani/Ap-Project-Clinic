using System;
using System.Collections.Generic;

namespace Ap_Project_Clinic_
{
    static class deleteturn
    {
        public static Boolean deleteturnfun(DateTime dayofturn, string fid)
        {
            string path = rateform.getpath() + "\\nobat.txt";
            List<nobatdehi> newlist = new List<nobatdehi>();
            string[] allinform1 = System.IO.File.ReadAllLines(path);
            Boolean result = false;
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                string[] dateofturn = personinform[0].Split('/');
                string[] timeofturn = personinform[1].Split(':');
                DateTime x = new DateTime(Convert.ToInt32(dateofturn[0]), Convert.ToInt32(dateofturn[1]), Convert.ToInt32(dateofturn[2]), Convert.ToInt32(timeofturn[0]), Convert.ToInt32(timeofturn[1]), Convert.ToInt32(timeofturn[2]));
                newlist.Add(new nobatdehi(x, personinform[6], personinform[3], personinform[11], Convert.ToBoolean(personinform[9]), Convert.ToBoolean(personinform[9])));
            }
            for (int i = 0; i <newlist.Count; i++)
            {
                if (newlist[i].date.Year == dayofturn.Year && newlist[i].date.Month == dayofturn.Month && newlist[i].date.Day == dayofturn.Day && newlist[i].idnumber == fid)
                {
                    newlist.RemoveAt(i);
                    result = true;

                }

            }
            System.IO.File.Delete(path);
            string save = "";
            for (int i = 0; i < newlist.Count; i++)
            {

                save+= newlist[i].date.Year + "/" + newlist[i].date.Month + "/" + newlist[i].date.Day + "/" + '*' + newlist[i].date.TimeOfDay.ToString() + '*' + newlist[i].minute+ '*' + newlist[i].work + '*' + newlist[i].name + '*' + newlist[i].familyname + '*' + newlist[i].idnumber + '*' + newlist[i].phone + '*' + newlist[i].shomarenobat + '*' + newlist[i].noteven + '*' + newlist[i].notodd + '*' + newlist[i].doctorname + '\n';

            }
            System.IO.File.AppendAllText(path, save);
            return result;



        }



    }
}

