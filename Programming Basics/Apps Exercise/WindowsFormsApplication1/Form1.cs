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

        private void button1_Click(object sender, EventArgs e)
        {
            
            var a = double.Parse(textBox1.Text);
            var b = double.Parse(textBox2.Text);
            var sum = a + b;
            textBox3.Text = sum.ToString();
            
            if (sum == 10)
                pictureBox1.Show();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var sum = 3+3;
            textBox3.Text = sum.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
