using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Zeynep Han tarafından hazırlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cehennemMelekleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=2li1Az35-7E");
            label1.Text = "Cehennem Melekleri";
            label1.BackColor = Color.DarkCyan;
        }

        private void aşkVeGururToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=cTZAzVzFShw");
            label1.Text = "Aşk ve Grur";
            label1.BackColor = Color.DarkRed;
            label1.ForeColor = Color.Coral;
        }

        private void senHiçAteşBöceğiGördünMüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=bdrcCFTXhzI");
            label1.Text = "Sen Hiç Ateş Böceği Gördün Mü?";
            label1.BackColor = Color.BlanchedAlmond;
            label1.ForeColor = Color.DarkTurquoise;
            
        }

        private void fantastikCanavarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=fL8TFdx-p7I");
            label1.Text = "Fantastik Canavarlar";
            label1.BackColor = Color.Aquamarine;
            label1.ForeColor = Color.Beige;
        }

        private void siccinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hunXjEN-09E");
            label1.Text = "Korku Seansı";
            label1.BackColor = Color.DarkTurquoise;
            label1.ForeColor = Color.Red;
        }
    }
}
