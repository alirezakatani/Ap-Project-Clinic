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
    public partial class payment_Installment : Form
    {
        List<Ipayment> pay = new List<Ipayment>();
       
        public payment_Installment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pay = readandwritepayment.get(dateTimePicker1.Value);
            dataGridView1.DataSource = pay;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            paymentturn.payalltoday(dateTimePicker1.Value);
        }
    }
}
