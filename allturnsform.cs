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
    public partial class allturnsform : Form
    {
        List<nobatdehi> turns = new List<nobatdehi>();
        List<Iturn> iturnlist = new List<Iturn>();
        readandwrite read = new readandwrite();
        public allturnsform()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
          
            turns=read.getallnobatbasespeanddate(dateTimePicker1.Value);
            foreach (nobatdehi turn in turns)
            {
                iturnlist.Add(turn);

            }
            dataGridView1.DataSource = iturnlist;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turns = read.getlistofallturnofoneperson(textBox1.Text);
            foreach (nobatdehi turn in turns)
            {
                iturnlist.Add(turn);
            }
            dataGridView1.DataSource = iturnlist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turns = read.getlistofallturnofoneperson(textBox1.Text);
            foreach (nobatdehi turn in turns)
            {
                iturnlist.Add(turn);
            }
            dataGridView1.DataSource = iturnlist;
        }
    }
}
