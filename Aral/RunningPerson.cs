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
    public partial class RunningPerson : Form
    {
        public RunningPerson()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int xx=350; int yy=350;
        int merc1X=180; int merc1Y=0;
        private void RunningPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "A"||e.KeyChar.ToString()=="a")
            {
                xx -= 5;
                bmw.Location=new Point(xx, yy);
            }
            else if (e.KeyChar.ToString() == "D"||e.KeyChar.ToString()=="d")
            {
                xx += 5;
                bmw.Location=new Point(xx, yy);
            }
        }
        Random ranX = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            merc1Y +=10;

            if (merc1.Location.Y >= 480)
            {
                merc1Y = 0;
                merc1X = ranX.Next(100, 484);

            }
            if (bmw.Bounds.IntersectsWith(merc1.Bounds))
            {
                timer1.Stop();
                Console.Beep();

            }
            merc1.Location = new Point(merc1X, merc1Y);
            if (terek1.Location.Y >= 480)
            {
                terek1.Location = new Point(terek1.Location.X, -20);
            }
            else if (terek2.Location.Y >= 480)
            {
                terek2.Location = new Point(terek2.Location.X, -20);
            }
            else if (terek3.Location.Y >= 480)
            {
                terek3.Location = new Point(terek3.Location.X, -20);
            }
            else if (terek4.Location.Y >= 480)
            {
                terek4.Location = new Point(terek4.Location.X, -20);
            }

            if (siziq1.Location.Y >= 480)
            {
                siziq1.Location = new Point(siziq1.Location.X, -20);
            }
            else if (siziq2.Location.Y >= 480)
            {
                siziq2.Location = new Point(siziq2.Location.X, -20);
            }
            else if (siziq3.Location.Y >= 480)
            {
                siziq3.Location = new Point(siziq3.Location.X, -20);
            }
            else if (siziq4.Location.Y >= 480)
            {
                siziq4.Location = new Point(siziq4.Location.X, -20);
            }
            else if (siziqR1.Location.Y >= 480)
            {
                siziqR1.Location = new Point(siziqR1.Location.X, -20);
            }
            else if (siziqR2.Location.Y >= 480)
            {
                siziqR2.Location = new Point(siziqR2.Location.X, -20);
            }
            else if (siziqR3.Location.Y >= 480)
            {
                siziqR3.Location = new Point(siziqR3.Location.X, -20);
            }
            else if (siziqR4.Location.Y >= 480)
            {
                siziqR4.Location = new Point(siziqR4.Location.X, -20);
            }

            terek1.Top += 5;
            terek2.Top += 5;
            terek3.Top += 5;
            terek4.Top += 5;

            siziq1.Top += 5;
            siziq2.Top += 5;
            siziq3.Top += 5;
            siziq4.Top += 5;
            siziqR1.Top += 5;
            siziqR2.Top += 5;
            siziqR3.Top += 5;
            siziqR4.Top += 5;
        }

      
        private void RunningPerson_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
