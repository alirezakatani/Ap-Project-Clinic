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
    public partial class cliniccosts : Form
    {
        string path = Application.StartupPath + "\\cost.txt";
        public double excost { get; set; }
        public double suonecost { get; set; }
        public double sutwocost { get; set; }
        public double rootcost { get; set; }
        public cliniccosts()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            excost = Convert.ToDouble(txtexam.Text);
            suonecost = Convert.ToDouble(txtonesurface.Text);
            sutwocost = Convert.ToDouble(txttwosurface.Text);
            rootcost = Convert.ToDouble(txtroot.Text);
            
        }
        private void saveinfile()
        {
            string saves = excost + "*" + suonecost + "*" + sutwocost + "*" + rootcost;
            System.IO.File.WriteAllText(path, saves);
        }
        public static string returncost(string work)
        {
            string paths = Application.StartupPath + "\\cost.txt";
            string[] cost = System.IO.File.ReadAllLines(paths);
            string[] costbase = cost[0].Split('*');

            if (work == "moayene")
            {
                return costbase[0];
            }
            else if (work == "tarmim1")
            {
                return costbase[1];
            }
            else if (work == "tarmim2")
            {
                return costbase[2];
            }
            else
            {
                return costbase[3];
            }

        }
    }
}
