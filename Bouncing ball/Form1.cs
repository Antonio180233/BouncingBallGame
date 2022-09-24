using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bouncing_ball{ 


    
    public partial class Form1 : Form
    {
        int BoundaryX = 723;
        int BoundaryY = 360;
        int vx = 4, vy = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Ball.Left = Ball.Left + vx;
            Ball.Top = Ball.Top + vy;
            if(Ball.Left > BoundaryX || Ball.Left <= 0)
            {
                vx *= -1;       // negative changes direction
            }
           
            if (Ball.Top > BoundaryY || Ball.Top < 0)
            {
                vy *= -1;
            }



        }
    }
}
