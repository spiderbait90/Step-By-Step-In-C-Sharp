using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.Графично_приложение_za_конвертор_за_валути
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedItem = "EUR";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        
        private void ConvertCurrency()
        {
            var originalAmount = this.numericUpDown1.Value;
            var convertedAmount = originalAmount;
            if (this.comboBox1.SelectedItem.ToString() == "EUR")
            {
                convertedAmount = originalAmount / 1.95583m;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "USD")
            {
                convertedAmount = originalAmount / 1.80810m;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "GBP")
            {
                convertedAmount = originalAmount / 2.54990m;
            }
            this.label1.Text = originalAmount + " лв. = " +
                Math.Round(convertedAmount, 2) + " " + this.comboBox1.SelectedItem;
        }
    }
}
