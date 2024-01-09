using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerorn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text=sayac.ToString();
            if (sayac == 0)
            {
                timer1.Stop();
            }
        }
        int sayac = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            timer1.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac = 0;
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
