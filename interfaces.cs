using System;

namespace Ap_Project_Clinic_
{

    public interface Iperson
    {
        string name { get; set; }
        string familyname { get; set; }
        string phone { get; set; }
        string idnumber { get; set; }

    }

    public interface Ipay : Iperson
    {

        string account { get; set; }
        double salary { get; set; }
        string checkout();
        double lastcash { get; set; }
        string name { get; set; }
        string familyname { get; set; }
        string idnumber { get; set; }

    }
    public interface Iturn : Iperson//nokte:be dalil nemayesh dadan name,familyname,... dar datagreed view be in inreface esafeshode ast
    {
        string name { get; set; }
        string familyname { get; set; }
        string phone { get; set; }
        DateTime date { get; set; }
        string work { get; set; }
        string path { get; set; }
        int minute { get; set; }
        string idnumber { get; set; }
        string fileid { get; set; }
        string doctorname { get; set; }
        Boolean noteven { get; set; }
        Boolean notodd { get; set; }
        int shomarenobat { get; set; }
    }
    public interface Ipayment
    {
         DateTime first { get; set; }
         string doctorname { get; set; }
         double money { get; set; }
         int numberofpayment { get; set; }

    }
    public interface IBime
    {
        double percent { get; set; }
        string name { get; set; }
        string familyname { get; set; }
        string id { get; set; }



    }

   

}
