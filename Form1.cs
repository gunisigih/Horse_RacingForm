using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(0, 10);
            pictureBox2.Left += rnd.Next(0, 10);
            pictureBox3.Left += rnd.Next(0, 10);
            pictureBox4.Left += rnd.Next(0, 10);
            pictureBox5.Left += rnd.Next(0, 10);
            pictureBox6.Left += rnd.Next(0, 10);
            if (pictureBox1.Right >= panel1.Left)
            {
                player.Stop();
                timer1.Stop();
                MessageBox.Show("1 Numara kazandı");
            }
            else if (pictureBox2.Right >= panel1.Left)
            {
                player.Stop();
                timer1.Stop();
                MessageBox.Show("2 Numara kazandı");
            }
            else if (pictureBox3.Right >= panel1.Left)
            {
                player.Stop();
                timer1.Stop();
                MessageBox.Show("3 Numara kazandı");
            }
            else if (pictureBox4.Right >= panel1.Left)
            {
                player.Stop();
                timer1.Stop();
                MessageBox.Show("4 Numara kazandı");
            }
            else if (pictureBox5.Right >= panel1.Left)
            {
                player.Stop();
                timer1.Stop();
                MessageBox.Show("5 Numara kazandı");
            }
            else if (pictureBox6.Right >= panel1.Left)
            {
                player.Stop();
                timer1.Stop();
                MessageBox.Show("6 Numara kazandı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //player.SoundLocation = @"C:\Users\Section2\source\repos\at.wav";

            //player.Play();
            timer1.Start();
            timer1.Interval = 100;
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
