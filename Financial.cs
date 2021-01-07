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
    public partial class FinancialForm : Form
    {
        public FinancialForm()
        {
            InitializeComponent();
        }

        private void btnsalary_Click(object sender, EventArgs e)
        {
            employessalary empform = new employessalary();
            empform.Show(this);

        }

        private void btnEquity_Click(object sender, EventArgs e)
        {
            sharmanform shform = new sharmanform();
            shform.Show(this);
        }

        private void btnmedical_Click(object sender, EventArgs e)
        {
            medicalexpform me = new medicalexpform();
            me.Show(this);
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {
            cliniccosts clicosform = new cliniccosts();
            clicosform.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paymentform x = new paymentform();
            x.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allpayform pay = new allpayform();
            pay.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            payment_Installment pay = new payment_Installment();
            pay.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bimes x = new Bimes();
            x.Show();
        }
    }
}
