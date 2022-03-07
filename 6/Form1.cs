using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        int[] A = new int[30];

        Random r = new Random();

        void showArray()
        {
            richTextBox1.Text = "";

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(-100, 100);

                richTextBox1.Text += $"A[{i}] = {A[i]}\n";
            }
        }

        void resultArray()
        {
            richTextBox2.Text = "";

            int[] newArray = new int[A.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (A[i] % 5 == 0 && A[i] % 7 != 0)
                {
                    newArray[i] = A[i];

                    richTextBox2.Text += $"A[{i}] = {newArray[i]}\n";
                }
                else
                {
                    newArray[i] = 0;

                    richTextBox2.Text += $"A[{i}] = {newArray[i]}\n";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            showArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultArray();
        }
    }
}
