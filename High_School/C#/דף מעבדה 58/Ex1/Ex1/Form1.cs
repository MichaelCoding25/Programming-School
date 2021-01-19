using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        int oldX;
        int oldY;
        int hitCounter;
        bool isActive;
        public Form1()
        {
            InitializeComponent();
            oldX = BombPicture.Location.X;
            oldY = BombPicture.Location.Y;
            hitCounter = 0;
            isActive = false;
            BoomPicture.Location = new Point(-1000, -1000);
            GameOverPicture.Location = new Point(-10000, -10000);
        }

        private void Button_start_Click(object sender, EventArgs e)
        {
            Move_Timer1.Interval = 1000/60;
            Move_Timer1.Enabled = true;
            isActive = true;
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            Move_Timer1.Enabled = false;
            isActive = false;
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            Hits_Label.Text = "Hits: " + 0;
            hitCounter = 0;
            BombPicture.Location = new Point(oldX, oldY);
            isActive = false;
            Move_Timer1.Enabled = false;
            BoomPicture.Location = new Point(-1000, -1000);
            GameOverPicture.Location = new Point(-10000, -10000);
        }

        private void Move_Timer1_Tick(object sender, EventArgs e)
        {
            int x = BombPicture.Location.X;
            int y = BombPicture.Location.Y;

            BombPicture.Location = new Point(x + 30, y);
            if (x > this.Size.Width)
            {
                GameOverPicture.Location = new Point(-6, -1);
                Move_Timer1.Enabled = false;
            }
        }

        private void BombPicture_Click(object sender, EventArgs e)
        { 
            if (isActive == true)
            {
                hitCounter++;
                Hits_Label.Text = "Hits: " + (0 + hitCounter);
                int x = BombPicture.Location.X;
                int y = BombPicture.Location.Y;
                BoomPicture.Location = new Point(x, y - 30);
                BombPicture.Location = new Point(-1000, -1000);
                Boom_Timer.Interval = 2000;
                Boom_Timer.Enabled = true;
            }
            
        }

        private void Boom_Timer_Tick(object sender, EventArgs e)
        {
            BoomPicture.Location = new Point(-1000, -1000);
            BombPicture.Location = new Point(oldX, oldY);
            Boom_Timer.Enabled = false;
        }
    }
}
