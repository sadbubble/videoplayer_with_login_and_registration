using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Microsoft.DirectX.AudioVideoPlayback.Video video;

        private void Form1_Load(object sender, EventArgs e)
        {
            video = new Video(@"Video\\countdown.mp4"); // for loading video from this dir
            video.Owner = panel1; //and video will be played in this panel
            video.Size = new Size(500, 170); //size for video from panel
            video.Play();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            video.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            video.Pause();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: \nNurtolgan Yessil", "Info");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
            if (video.Playing)
            {
                video.Pause();
            }
            else {
                video.Play();
            }
            
   
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                video.Stop();
                video.Open(openFileDialog1.FileName);
                video.Owner = panel1;
                video.Size = new Size(500, 170);
                video.Play();


            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (video.Playing)
            {
                video.Pause();
            }
            else
            {
                video.Play();
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
