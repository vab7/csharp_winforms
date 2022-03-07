using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Label label = new Label();
            label.Text = "some label";
            label.Location = new Point(random.Next(500), random.Next(500));

            Controls.Add(label);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            TextBox textBox = new TextBox();
            textBox.Text = "some textBox";
            textBox.Location = new Point(random.Next(500), random.Next(500));

            Controls.Add(textBox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Button button = new Button();
            button.Text = "some button";
            button.Location = new Point(random.Next(500), random.Next(500));

            Controls.Add(button);
        }
    }
}
