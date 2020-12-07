namespace Ap_Project_Clinic_
{
    class shareman
    {
        public static string getinformation(string id,string path)
        {
            string [] allinform1 = System.IO.File.ReadAllLines(path);
            for (int i = 0; i < allinform1.Length; i++)
            {
                string[] personinform = allinform1[i].Split('*');
                if (personinform[5] == id)
                    return allinform1[i];
            }
            return null; 
        }

    }
}
