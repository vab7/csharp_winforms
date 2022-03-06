using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        static double result = 0.0,
               x = 0.5,
               b = 2.2;

        double formula = Math.Pow(x, 2);

        void showResult()
        {
            richTextBox1.Text = $"Результаты работы программы Белоусова\n\n" +
                $"X = {x}\n" +
                $"Y = {b}\n\n" +
                $"s = {result}";
        }

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = $"{x}";
            textBox2.Text = $"{b}";

            showResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            double mult = x * b;

            if (1 < mult && mult < 10)
            {
                result = Math.Pow(Math.E, formula);
            }
            else if (12 < mult && mult < 40)
            {
                result = Math.Sqrt(formula + 4 * b);
            }
            else
            {
                result = b * Math.Pow(formula, 2);
            }

            showResult();
        }
    }
}
