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
    public partial class TezJaz : Form
    {
        public TezJaz()
        {
            InitializeComponent();
        }
        string shortText = "hay heir harp half hang hack hex high echo earn elan eddy edit obit oboe obey owl oak okie dokey down duty dux dixy doxy xmas xtal nix next note name nape nail snap spar step slow shot shit qua quay quad quod quit pack pray pure pig pixy push rush rue rock rose rich ring main mad male melt milk make zero zest zonk zoom zinc zing year yelp ywis your chip char cut chut coxy cow kale ken knap keep keck kiwi with wind wick woke wont void volt vole vote vita vox vug very jerk joke jack jab job jamb jeep girl glue gold grow good luck lake lid lie lex live love";
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt1.Text = shortText;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void TezJaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == txt1.Text[0])
            {
                txt2.Text += txt1.Text[0];
                txt1.Text = txt1.Text.Substring(1);
                if (txt2.Text.Length > 20)
                {
                    txt2.Text = txt2.Text.Substring(1);

                }
            }
        }
    }
}
