using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        double x = 0.1722,
               y = 6.33,
               z = 0.00325,
               result = 0.0;

        void printResult()
        {
            richTextBox1.Text = "Лаб. раб №2 Белоусов Владимир\n\n" +
                $"X = {x}\n" +
                $"Y = {y}\n" +
                $"Z = {z}\n\n" +
                $"Результат γ = {result}";
        }

        public Form1()
        {
            InitializeComponent();

            printResult();

            textBox1.Text = x.ToString();
            textBox2.Text = y.ToString();
            textBox3.Text = z.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);
            z = double.Parse(textBox3.Text);

            result = 5 * Math.Atan(x) - 0.25 * Math.Acos(x) * ((x + 3 * Math.Abs(x - y) * +Math.Pow(x, 2)) / Math.Abs(x - y) * z + Math.Pow(x, 2));
        
            printResult();
        }
    }
}
