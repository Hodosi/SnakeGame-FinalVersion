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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
        }

        Random rnd = new Random();
        List<Label> labels = new List<Label>();
        Label new_label;
        int act;
        int x, y, randX, randY, endX, endY;
        int move_distance = 15;
        int ln = 3;

        public void reset_game()
        {
            for (int i = 3; i < ln; i++)
            {
                this.Controls.Remove(labels[3]);
                labels.Remove(labels[3]);
            }
            ln = 3;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }

        public void timer_control(int x)
        {
            Timer[] timers = new Timer[] { timer1, timer2, timer3, timer4 };
            for (int i = 0; i < 4; i++)
                if (i == x)
                {
                    timers[i].Start();
                }
                else
                {
                    timers[i].Stop();
                }
        }
        public int active_timer()
        {
            Timer[] timers = new Timer[] { timer1, timer2, timer3, timer4 };
            for (int i = 0; i < 4; i++)
                if (timers[i].Enabled == true)
                    return i + 1;
            return 0;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            act = active_timer();
            switch (e.KeyCode)
            {
                case (Keys.Up):
                    if (act == 1 || act == 2)
                        return;
                    move_once_up();
                    timer_control(0);
                    break;
                case (Keys.Down):
                    if (act == 1 || act == 2)
                        return;
                    move_once_down();
                    timer_control(1);
                    break;
                case (Keys.Left):
                    if (act == 3 || act == 4)
                        return;
                    move_once_left();
                    timer_control(2);
                    break;
                case (Keys.Right):
                    if (act == 3 || act == 4)
                        return;
                    move_once_right();
                    timer_control(3);
                    break;
            }
        }

        public bool game_over (int a, int b)
        {
            decimal absX,absY;
            for (int i = 3; i < ln; i++)
            {
                absX = a - labels[i].Location.X;
                absY = b - labels[i].Location.Y;
                if (Math.Abs(absX)<15 && Math.Abs(absY)<15)
                    return true;
            }
            return false;
        }
        public bool catched(int a, int b)
        {
            if (a > label0.Location.X - label1.Size.Width &&
                a < label0.Location.X + label0.Size.Width &&
                b > label0.Location.Y - label1.Size.Height &&
                b < label0.Location.Y + label0.Size.Height)
                return true;
            return false;
        }
        public bool valid (int a,int b)
        {
            int new_food_X,new_food_Y;
            for (int i = 0; i < ln; i++)
            {
                new_food_X = a - labels[i].Location.X;
                new_food_Y = b - labels[i].Location.Y;
                if (Math.Abs(new_food_X) < 15 && Math.Abs(new_food_Y) < 15)
                    return false;
            }
            return true;
        }

        public void newfood()
        {   
            randX = rnd.Next(0, this.Size.Width - label0.Size.Width - 20);
            randY = rnd.Next(0, this.Size.Height - label0.Size.Height - 50);
            while (valid(randX,randY) == false)
            {
                randX = rnd.Next(0, this.Size.Width - label0.Size.Width - 20);
                randY = rnd.Next(0, this.Size.Height - label0.Size.Height - 50);
            }
            label0.Location = new Point(randX, randY);
        }

        public void endsnake(int a, int b)
        {
            endX = a;
            endY = b;
        }

        public void newlabel(int a)
        {
            new_label = new Label();
            new_label.BackColor = System.Drawing.Color.Lime;
            new_label.Location = new System.Drawing.Point(endX, endY);
            new_label.Margin = new System.Windows.Forms.Padding(0);
            new_label.Name = "label" + a.ToString();
            new_label.Size = new System.Drawing.Size(15, 15);
            new_label.TabIndex = a;
            this.Controls.Add(new_label);
            labels.Add(new_label);
        }

        public void moveAll(int newX, int newY)
        {
            int oldX, oldY;
            for (int i = 1; i < ln; i++)
            {
                oldX = labels[i].Location.X;
                oldY = labels[i].Location.Y;
                labels[i].Location = new Point(newX, newY);
                newX = oldX;
                newY = oldY;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            move_once_up();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            move_once_down();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            move_once_left();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            move_once_right();
        }
        public void move_once_up()
        {
            x = label1.Location.X;
            y = label1.Location.Y - move_distance;
            if (y >= -10)
            {
                label1.Location = new Point(x, y);
                moveAll(x, y + move_distance);
            }
            else
            {
                y = this.Height - label1.Height;
                label1.Location = new Point(x, y);
                moveAll(x, y + move_distance);
                move_once_up();
            }
            if(game_over(x,y))
            {
                reset_game();
                DialogResult result = MessageBox.Show("Do you want to play again?", "Replay", MessageBoxButtons.YesNo);
                if(result==DialogResult.No)
                    this.Close();
            }
            if (catched(x, y))
            {
                newfood();
                endsnake(x, y + move_distance);
                newlabel(++ln);
            }
        }

        public void move_once_down()
        {
            x = label1.Location.X;
            y = label1.Location.Y + move_distance;
            if (y <= this.Height - label1.Height - 30)
            {
                label1.Location = new Point(x, y);
                moveAll(x, y - move_distance);
            }
            else
            {  
                y = 0;
                label1.Location = new Point(x, y);
                moveAll(x, y + move_distance);
                move_once_down();
            }
            if (game_over(x, y))
            {
                reset_game();
                DialogResult result = MessageBox.Show("Do you want to play again?", "Replay", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    this.Close();
            }
            if (catched(x, y))
            {
                newfood();
                endsnake(x, y - move_distance);
                newlabel(++ln);
            }
        }

        public void move_once_left()
        {
            x = label1.Location.X - move_distance;
            y = label1.Location.Y;
            if (x >= 0)
            {
                label1.Location = new Point(x, y);
                moveAll(x + move_distance, y);
            }
            else
            {
                x = this.Width - label1.Width;
                label1.Location = new Point(x, y);
                moveAll(x, y + move_distance);
                move_once_left();
            }
            if (game_over(x, y))
            {
                reset_game();
                DialogResult result = MessageBox.Show("Do you want to play again?", "Replay", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    this.Close();
            }
            if (catched(x, y))
            {
                newfood();
                endsnake(x + move_distance, y);
                newlabel(++ln);
            }
        }

        public void move_once_right()
        {
            x = label1.Location.X + move_distance;
            y = label1.Location.Y;
            if (x <= this.Width - label1.Width - 10)
            { 
                label1.Location = new Point(x, y);
                moveAll(x - move_distance, y);
            }
            else
            {
                x = 0;
                label1.Location = new Point(x, y);
                moveAll(x, y + move_distance);
                move_once_right();
            }
            if (game_over(x, y))
            {
                reset_game();
                DialogResult result = MessageBox.Show("Do you want to play again?", "Replay", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    this.Close();
            }
            if (catched(x, y))
            {
                newfood();
                endsnake(x - move_distance, y);
                newlabel(++ln);
            }
        }
    }
}
