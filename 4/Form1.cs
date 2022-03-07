using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        double x0 = -2.4,
            xk = 1,
            dx = 0.2,
            b = 2.5,
            y = 0.0;

        void showResult()
        {
            x0 = double.Parse(textBox1.Text);
            xk = double.Parse(textBox2.Text);
            dx = double.Parse(textBox3.Text);
            b = double.Parse(textBox4.Text);

            richTextBox1.Text = $"Работу выполнил Белоусов В.А.\n\n";

            while (x0 <= (xk + dx / 2))
            {
                y = 9 * (x0 + 15 * Math.Sqrt(Math.Pow(x0, 3) + Math.Pow(b, 3)));

                richTextBox1.Text += $"x = {x0}; y = {y}\n";

                x0 += dx;
            }
        }

        void showTextBoxValue()
        {
            textBox1.Text = $"{x0}";
            textBox2.Text = $"{xk}";
            textBox3.Text = $"{dx}";
            textBox4.Text = $"{b}";
        }

        public Form1()
        {
            InitializeComponent();

            showTextBoxValue();

            showResult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResult();
        }
    }
}
