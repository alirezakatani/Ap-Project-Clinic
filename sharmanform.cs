using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap_Project_Clinic_
{
    public partial class sharmanform : Form
    {
        string path = Application.StartupPath + @"\shareman.txt";
        public sharmanform()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string account;
            string pathsaveaccount = rateform.getpath() + "\\account.txt";
            string information = txtname.Text +'*'+ txtfamilyname.Text+'*' + txtsalpercent.Text +'*'+ txtsharepercent.Text +'*'+ txtid.Text +'*'+txtaccount.Text+"\n";
            account = txtname.Text + '*' + txtfamilyname.Text +'*'+txtaccount.Text+ '*' + 0 + '*' + DateTime.Now+'*'+"shareman";
            System.IO.File.AppendAllText(path, information);
            System.IO.File.AppendAllText(pathsaveaccount, account);
            
        }
    }
}
