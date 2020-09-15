using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unreal_Snake
{
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        public void set_timerSpeed(int lvl){
            int speed = 0;
            switch (lvl)
            {
                case 0:
                    speed = 250;
                    break;
                case 1:
                    speed = 150;
                    break;
                case 2:
                    speed = 50;
                    break;
                case 3:
                    speed = 10;
                    break;
            }
            frm.timer1.Interval = speed;
            frm.timer2.Interval = speed;
            frm.timer3.Interval = speed;
            frm.timer4.Interval = speed;
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button_easy_Click(object sender, EventArgs e)
        {
            set_timerSpeed(0);
        }

        private void button_medium_Click(object sender, EventArgs e)
        {
            set_timerSpeed(1);
        }

        private void button_hard_Click(object sender, EventArgs e)
        {
            set_timerSpeed(2);
        }

        private void button_2020_Click(object sender, EventArgs e)
        {
            set_timerSpeed(3);
        }
    }
}
