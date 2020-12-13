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
    public partial class medicalexpform : Form
    {
        string path = Application.StartupPath + "\\medicalexpnses.txt";
        public medicalexpform()
        {
            InitializeComponent();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            string saves = txtkind + "*" + txtcost;
            System.IO.File.AppendAllText(path + "\\nobat.txt", saves);
        }
      
    }
}
