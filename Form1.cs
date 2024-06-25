using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinama_Fragman_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;
        }

        private void madManToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webView1.Source = new Uri("https://youtu.be/B8b0B2-hvhc?si=XUitsCnpJlkq-Ijx");
            label1.Text = "Mad Max";
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Source = new Uri("https://www.youtube.com/watch?v=5u5A471adxg&ab_channel=WarnerBrosTurkey");
            label1.Text = "Korku Seası";
        }

        private void psILoveYouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Source = new Uri("https://www.youtube.com/watch?v=CZzW6_hR068&ab_channel=Movieclips");
            label1.Text = "PS: I Love You";

        }

        private void aynıYıldızınAltıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Source = new Uri("https://www.youtube.com/watch?v=83oJrmb0nHw&ab_channel=MyBilet");
            label1.Text = "Aynı Yıldızın Altı";

        }

        private void uzayYolculuğuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webView1.Source = new Uri("https://www.youtube.com/watch?v=ladjvJa7FuQ&ab_channel=Seologa");
            label1.Text = "Uzay Yolculuğu";
        }
    }
}
