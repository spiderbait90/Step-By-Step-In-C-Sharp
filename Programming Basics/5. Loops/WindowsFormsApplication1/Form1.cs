using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = 200;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <6; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(60);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Green;
            for (int i = 0; i < 6; i++)
            {
                
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(i*10);
                Turtle.Rotate(60);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(250);
            }
        }
    }
}
