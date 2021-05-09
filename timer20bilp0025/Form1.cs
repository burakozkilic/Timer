using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer20bilp0025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac = 0;
        }
        int sayac = 100, saniye=0, dakika=0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            progressBar1.Value = sayac;
            saniye++;
            if(saniye<=59)
            {
                progressBar3.Value = saniye;
                label5.Text = saniye.ToString();
            }
            else
            {
                dakika++;
                saniye = 0;
                if (dakika < 60)
                {
                    progressBar2.Value = dakika;
                    label4.Text = dakika.ToString();
                }
                else
                {
                    saniye = 0;
                    dakika = 0;
                }
                    
            }
        }
    }
}
