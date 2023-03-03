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
    public partial class FastMath : Form
    {
        int juwap = 0;
        public FastMath()
        {
            InitializeComponent();
            timer1.Start();
            label1.Text = randX.Next(1, 100).ToString();
            label3.Text = randX.Next(1, 100).ToString();
            juwap =int.Parse(label1.Text)+int.Parse(label3.Text);
            this.Text = juwap.ToString();
            int x4 = randX.Next(1, 5);
            button1.Text = (juwap + 10).ToString();
            button2.Text = (juwap - 10).ToString();
            button3.Text = (juwap + 1).ToString();
            button4.Text = (juwap - 1).ToString();
            if ( x4== 1)
            {
                button1.Text = juwap.ToString();
            }
            else if (x4 == 2)
            {
                button2.Text = juwap.ToString();
            }
            else if (x4 == 3)
            {
                button3.Text = juwap.ToString();
            }
            else if (x4 == 4)
            {
                button4.Text = juwap.ToString();
            }

        }
        Random randX= new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value >= 10)
                progressBar1.Value -= 10;
            else
                timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tekser(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tekser(button2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tekser(button4);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tekser(button3);

        }

        void tekser(Button btn)
        {
            if (btn.Text == juwap.ToString())
            {
                ornina_qoy();
                if (progressBar1.Value <= 50)
                {
                    progressBar1.Value += 50;
                }
                else
                {
                    progressBar1.Value = 100;
                }
            }
            else
            {
                if(progressBar1.Value>=5)
                {
                    progressBar1.Value -= 5;
                }
            }
        }

        void ornina_qoy()
        {
            label1.Text = randX.Next(1, 100).ToString();
            label3.Text = randX.Next(1, 100).ToString();
            juwap = int.Parse(label1.Text) + int.Parse(label3.Text);
            this.Text = juwap.ToString();
            int x4 = randX.Next(1, 5);
            button1.Text = (juwap + 10).ToString();
            button2.Text = (juwap - 10).ToString();
            button3.Text = (juwap + 1).ToString();
            button4.Text = (juwap - 1).ToString();
            if (x4 == 1)
            {
                button1.Text = juwap.ToString();
            }
            else if (x4 == 2)
            {
                button2.Text = juwap.ToString();
            }
            else if (x4 == 3)
            {
                button3.Text = juwap.ToString();
            }
            else if (x4 == 4)
            {
                button4.Text = juwap.ToString();
            }
        }

    }
}
