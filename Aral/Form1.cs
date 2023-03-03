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
    public partial class Form1 : Form
    {
        int sum = 0;
        public Form1()
        {
            InitializeComponent();// okno ashilganda isleydi
        }
        int Xball=0,Yball=0;
        void Xyamasa0(Button btnName)
        {
            

            btnName.Enabled= false;
            if (sum % 2 == 0)
            {
                btnName.Text = "X";
            }
            else btnName.Text = "0";


            if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text == "X")//g1
            { // a1 a2 a3
                Xball++;
                basilmaydi();
                a1.BackColor = Color.Red;
                a2.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                qaysi_utti();
            }
            else if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Text == "0")//g1
            {// a1 a2 a3
                Yball++;
                basilmaydi(); 
                a1.BackColor = Color.Green;
                a2.BackColor = Color.Green;
                a3.BackColor = Color.Green;
                qaysi_utti();
            }
            else if (a4.Text == a5.Text && a5.Text == a6.Text && a4.Text == "X")//g2
            {// 4 5 6
                Xball++;
                basilmaydi();
                a4.BackColor = Color.Red;
                a5.BackColor = Color.Red;
                a6.BackColor = Color.Red;
                qaysi_utti();
            }
            else if (a4.Text == a5.Text && a5.Text == a6.Text && a4.Text == "0")//g2
            {// 4 5 6
                Yball++;
                basilmaydi();
                a4.BackColor = Color.Green;
                a5.BackColor = Color.Green;
                a6.BackColor = Color.Green;
                qaysi_utti();
            }
            else if (a7.Text == a8.Text && a8.Text == a9.Text && a7.Text == "X")//g3
            {//7 8 9
                Xball++;
                basilmaydi();
                a4.BackColor = Color.Red;
                a8.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                qaysi_utti();
            }
            else if (a7.Text == a8.Text && a8.Text == a9.Text && a7.Text == "0")//g3
            {//7 8 9
                Yball++;
                basilmaydi();
                a1.BackColor = Color.Green;
                a2.BackColor = Color.Green;
                a3.BackColor = Color.Green;
                qaysi_utti();
            }
            else if (a1.Text == a4.Text && a4.Text == a7.Text && a1.Text == "X")//v1
            {// 1 4 7
                Xball++;
                basilmaydi();
                a1.BackColor = Color.Red;
                a2.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                qaysi_utti();
            }
            else if(a1.Text == a4.Text && a4.Text == a7.Text && a1.Text == "0")//v1
            {// 1 4 7
                Yball++;
                basilmaydi();
                a1.BackColor = Color.Green;
                a2.BackColor = Color.Green;
                a3.BackColor = Color.Green;
                qaysi_utti();
            }
            else if (a2.Text == a5.Text && a5.Text == a8.Text && a2.Text == "X")//v2
            {// 2 5 8
                Xball++;
                basilmaydi();
                a1.BackColor = Color.Red;
                a2.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                qaysi_utti();
            }
            else if(a2.Text == a5.Text && a5.Text == a8.Text && a2.Text == "0")//v2
            {// 2 5 8
                Yball++;
                basilmaydi();
                a1.BackColor = Color.Green;
                a2.BackColor = Color.Green;
                a3.BackColor = Color.Green;
                qaysi_utti();
            }
            else if (a3.Text == a6.Text && a6.Text == a9.Text && a3.Text == "X")//v3
            {// 3 6 9
                Xball++;
                basilmaydi();
                a1.BackColor = Color.Red;
                a2.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                qaysi_utti();
            }
            else if(a3.Text == a6.Text && a6.Text == a9.Text && a3.Text == "0")//v3
            {// 3 6 9
                Yball++;
                basilmaydi();
                a1.BackColor = Color.Green;
                a2.BackColor = Color.Green;
                a3.BackColor = Color.Green;
                qaysi_utti();
            }
            else if (a1.Text == a5.Text && a5.Text == a9.Text && a1.Text == "X")//x1
            { // 1 5 9
                Xball++;
                basilmaydi();
                a1.BackColor = Color.Red;
                a2.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                qaysi_utti();
            }
            else if(a1.Text == a5.Text && a5.Text == a9.Text && a1.Text == "0")//x1
            { //1 5 9
                Yball++;
                basilmaydi();
                a1.BackColor = Color.Green;
                a2.BackColor = Color.Green;
                a3.BackColor = Color.Green;
                qaysi_utti();
            }
            else if (a3.Text == a5.Text && a5.Text == a7.Text && a3.Text == "X")//x2
            {// 3 5 7
                Xball++;
                basilmaydi();
                a1.BackColor = Color.Red;
                a2.BackColor = Color.Red;
                a3.BackColor = Color.Red;
                qaysi_utti();
            }
            else if(a3.Text == a5.Text && a5.Text == a7.Text && a3.Text == "0")//x2
            {// 3 5 7
                Yball++;
                basilmaydi();
                a1.BackColor = Color.Green;
                a2.BackColor = Color.Green;
                a3.BackColor = Color.Green;
                qaysi_utti();
            }
            label1.Text = "Ball X: " + Xball.ToString();
            label2.Text = "Ball O: " + Yball.ToString();

            sum++;
        }

        void qaysi_utti()
        {
            panel2.Visible = true;
            if(Xball>Yball)
            {
                label5.Text = "X";
                label6.Text = "O";
            }
            else if(Yball>Xball)
            {
                label6.Text = "X";
                label5.Text = "O";
            }
        }
        void basilmaydi()
        {
            a1.Enabled = false;
            a2.Enabled = false;
            a3.Enabled = false;
            a4.Enabled = false;
            a5.Enabled = false;
            a6.Enabled = false;
            a7.Enabled = false;
            a8.Enabled = false;
            a9.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xyamasa0(a1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Xyamasa0(a2);
        }

        private void a3_Click(object sender, EventArgs e)
        {
            Xyamasa0(a3);

        }

        private void a4_Click(object sender, EventArgs e)
        {
            Xyamasa0(a4);

        }

        private void a5_Click(object sender, EventArgs e)
        {
            Xyamasa0(a5);

        }

        private void a6_Click(object sender, EventArgs e)
        {
            Xyamasa0(a6);

        }

        private void a7_Click(object sender, EventArgs e)
        {
            Xyamasa0(a7);

        }

        private void a8_Click(object sender, EventArgs e)
        {
            Xyamasa0(a8);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.SendToBack();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void a9_Click(object sender, EventArgs e)
        {
            Xyamasa0(a9);

        }
    }
}
