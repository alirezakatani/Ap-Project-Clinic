﻿using System;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Boolean x= deleteturn.deleteturnfun(dateturn.Value, txtfileid.Text);
            if(x==true)
            {
                txtresult.Text = "succsesful";
            }
            else
            {
                txtresult.Text = "faild";
            }    

        }
    }
}