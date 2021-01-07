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
    public partial class freetime : Form
    {
        
        public freetime(DateTime x)
        {
            InitializeComponent();
            dateTimePicker1.Value = x;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            nobatdehi temp = new nobatdehi();
            temp.doctorname = txtdoctorname.Text;
            managenobat manage = new managenobat(temp);
            txtfrom.Text = manage.getfreetime(dateTimePicker1.Value).TimeOfDay.ToString();
            DateTime xs = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 20, 0, 0);
            txtto.Text = xs.TimeOfDay.ToString();
        }
    }
}
