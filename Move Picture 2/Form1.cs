using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y);
            await Task.Delay(700);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 100, pictureBox1.Location.Y);
            await Task.Delay(700);
        }
        // this is the code for moving the picture right
        private async void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 100);
            await Task.Delay(600);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 100);
            await Task.Delay(600); 
        }
        // this is the code for moving the picture down
        private async void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 100, pictureBox1.Location.Y);
            await Task.Delay(700);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y);
            await Task.Delay(700);
        }
        // this is the code for moving the picture left
        private async void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 100);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 100);
            await Task.Delay(500);
        }
        // this is the code for moving the picture up
        private async void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 100);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 100, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 100);
            await Task.Delay(500);
        }
        // this is the code for moving the picture in a square
        private async void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y + 100);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y - 100);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 200, pictureBox1.Location.Y);
            await Task.Delay(500);
        }
        // this is the code for moving the picture in a triangle
        private async void button6_Click_1(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X + 100 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 100, pictureBox1.Location.Y);
                await Task.Delay(500);
            }
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
