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
    }
}
