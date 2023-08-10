using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace hafta11_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        bool right, left, up, down;
        int hiz = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (right == true)
            {
                if (pb_canli.Left + hiz <= 502)
                    pb_canli.Left += hiz;
            }
            else if (left == true)
            {
                if (pb_canli.Left - hiz >= 12)
                    pb_canli.Left -= hiz;
            }
            else if (up == true)
            {
                if (pb_canli.Top - hiz >= 47)
                    pb_canli.Top -= hiz;
            }
            else if (down == true)
            {
                if (pb_canli.Top + hiz <= 469)
                    pb_canli.Top += hiz;
            }

            if (pb_canli.Bounds.IntersectsWith(pb_Yildiz.Bounds) == true)
                yildiz_update();


        }
        SoundPlayer pl, pl1;

        private void Form1_Load(object sender, EventArgs e)
        {
            right = left = up = down = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            rnd = new Random();
            pl = new SoundPlayer(@"ses.wav.wav");
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = false;
            if (e.KeyCode == Keys.Left)
                left = false;
            if (e.KeyCode == Keys.Up)
                up = false;
            if (e.KeyCode == Keys.Down)
                down = false;
        }
        Random rnd;
        int kalan = 60;
        private void timer3_Tick(object sender, EventArgs e)
        {
            kalan--;
            if (kalan == 0)
            {
                lb_kalan.Text = "Kalan Süre = " + kalan.ToString();
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                if (DialogResult.Yes == MessageBox.Show("Oyun Bitti. Toplam Puan = " + puan.ToString() + "\nYeniden Başlat?", "FINISH", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    puan = 0;
                    sure = 100;
                    kalan = 60;
                    timer1.Enabled = true;
                    timer2.Enabled = true;
                    timer3.Enabled = true;
                }
                else
                    Application.Exit();
            }
            lb_kalan.Text = "Kalan Süre = " + kalan.ToString();
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = true;
            if (e.KeyCode == Keys.Left)
                left = true;
            if (e.KeyCode == Keys.Up)
                up = true;
            if (e.KeyCode == Keys.Down)
                down = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure--;
            if (sure == 0)
                timer2.Enabled = false;
            lb_sure.Text = "Süre = " + sure.ToString();
        }

        int puan = 0;
        int sure = 100;
        private void yildiz_update()
        {
            
            puan += sure;
            if (sure > 0)
                pl.Play();
            
            sure = 100;
            
            timer2.Enabled = true;
            lb_puan.Text = "Puan = " + puan.ToString();
            pb_Yildiz.Left = rnd.Next(15, 580);
            pb_Yildiz.Top = rnd.Next(53, 371);
        }
    }
}