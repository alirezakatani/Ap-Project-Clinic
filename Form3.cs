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
    public partial class Form3 : Form
    {
        string path = Application.StartupPath + @"\shareman.txt";
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string information = txtname.Text +'*'+ txtfamilyname.Text+'*' + txtsalpercent.Text +'*'+ txtsharepercent.Text +'*'+ txtid.Text +'*'+txtaccount.Text+"\n";
            System.IO.File.AppendAllText(path, information);
            
        }
    }
}
