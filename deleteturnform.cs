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
    public partial class deleteturnform : Form
    {
        public deleteturnform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { /* Boolean x= deleteturn.deleteturnfun(dateturn.Value, txtfileid.Text);*/
            nobatdehi delno = new nobatdehi();
            delno.date = dateturn.Value;
            managenobat manage = new managenobat(delno);
            Boolean x = manage.deletenobat(dateturn.Value, txtfileid.Text);
            if(x==true)
            {
                txtresult.Text = "succsesful";
            }
            else
            {
                txtresult.Text = "faild";
            }    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deletepath = rateform.getpath() + "\\deletednobat.txt";
            System.IO.File.Delete(deletepath);
        }
    }
}
