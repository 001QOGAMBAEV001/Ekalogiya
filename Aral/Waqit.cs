using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aral
{
    public partial class Waqit : Form
    {
        public Waqit()
        {
            InitializeComponent();
            //timer1.Start();
        }
        int tik = 0, tok = 0;

        private void Waqit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(tok + ":" + tik);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Text = "Start";
            if (button2.Text == "Start")
            {
                button2.Text = "Stop";  

                timer1.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tok = int.Parse(textBox1.Text.Split(':')[0]);
            tik = int.Parse(textBox1.Text.Split(':')[1]);
            timer2.Start();
            textBox1.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tik == 0)
            {
                tik = 59;
                tok--;
            }
            else
            {
                if (tik >= 0 && tik <= 9&&tok>=0&&tok<=9)
                {
                    label1.Text = "0"+tok + ":0" + tik;

                }
                tik--;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (tik == 59)
            {
                tok++;
                tik = 0;
            }
            else
            {
                tik++;
            }
            label1.Text = tok +":"+ tik;

        }
    }
}
