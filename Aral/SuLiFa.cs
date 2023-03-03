using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using WMPLib;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aral
{
    public partial class SuLiFa : Form
    {
        public SuLiFa()
        {
            InitializeComponent();
            aa.settings.volume = 30;
            aa.URL= "C:\\Users\\qogam\\Music\\qosiq1.mp3";
        }
        WindowsMediaPlayer aa = new WindowsMediaPlayer();
        WindowsMediaPlayer uttiEffekt = new WindowsMediaPlayer();
        void sayla(Button btn)
        {
            Random aa = new Random();
            int san = aa.Next(0, 3);
            if (san == 0)
            {
                button4.BackColor = Color.Red;
                button4.Location = new Point(336, 145);
                uttiYAulildi(btn, button4);
            }
            else if (san == 1)
            {
                button5.BackColor = Color.Red;
                button5.Location = new Point(336, 145);
                uttiYAulildi(btn, button5);
            }
            else if (san == 2)
            {
                button6.Location = new Point(336, 145);
                button6.BackColor = Color.Red;
                uttiYAulildi(btn, button6);
            }
            Button reset = new Button();
            reset.Size=new Size(200, 50);
            reset.Location = new Point(50, 171);
            reset.BackColor= Color.Yellow;
            reset.Visible = true;

            reset.Click += new System.EventHandler(this.reset_basilganda);
            reset.Text = "Reset";
            //reset.Font = new Font(FontFamily.GenericSansSerif, 25a, FontStyle.Bold);
            Controls.Add(reset);
            //reset.Show();
        }
        int sumPlayer = 0, sumBot = 0;
        void uttiYAulildi(Button Player,Button PlayerBot)
        {
            uttiEffekt.settings.volume = 100;
            if (Player == button1&&PlayerBot==button4)
            {
                sumPlayer++;
                uttiEffekt.URL = "C:\\Users\\qogam\\Music\\effect_utti.mp3";
            }
            else if(Player == button2 && PlayerBot == button5)
            {
                sumPlayer++;
                uttiEffekt.URL = "C:\\Users\\qogam\\Music\\effect_utti.mp3";

            }
            else if(Player == button3 && PlayerBot == button6)
            {
                sumPlayer++;
                uttiEffekt.URL = "C:\\Users\\qogam\\Music\\effect_utti.mp3";
            }
            else if(Player == button2 && PlayerBot == button4)
            {
                this.Text = "Game Over!";
                sumBot++;
            }
            else if(Player == button3 && PlayerBot == button5)
            {
                this.Text = "Game Over!";
                sumBot++;
            }
            else if(Player == button1 && PlayerBot == button6)
            {
                this.Text = "Game Over!";
                sumBot++;
            }
            else
            {
                this.Text = "Teń!";
            }
            lbl_ballP.Text = "Player: " + sumPlayer.ToString();
            lbl_ballB.Text = "Bot: " + sumBot.ToString();

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            sayla(button2);
            button2.Location = new Point(336, 257);
            button2.BackColor = Color.Green;
        }
        private void reset_basilganda(object sender, EventArgs e)
        {
            //this.Text = "SuLiFa";
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button1.Location = new Point(121, 369);
            button2.Location = new Point(353, 369);
            button3.Location = new Point(566, 369);
            button4.Location = new Point(569, 21);
            button5.Location = new Point(346, 21);
            button6.Location = new Point(116, 21);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayla(button1);
            button1.Location = new Point(336, 257);
            button1.BackColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayla(button3);
            button3.Location = new Point(336, 257);
            button3.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form keyingiAyna = new TezJaz();
            this.SendToBack();
            keyingiAyna.Show();
        }

        private void SuLiFa_Load(object sender, EventArgs e)
        {

        }
    }
}
