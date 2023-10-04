using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickathon3000
{
    public partial class Informacija : Form
    {
        public Informacija()
        {
            InitializeComponent();
        }

        private void Informacija_Load(object sender, EventArgs e)
        {
            label1.Text = Prenos.Naslov;
            label2.Text = Prenos.Tekst;
            Text = Prenos.Naslov;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new(@"lajanje.wav");
            player.Play();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = "https://www.lukastefanovic.com/";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = linkLabel2.Text;
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = uri
            };
            System.Diagnostics.Process.Start(psi);
        }
    }
}
