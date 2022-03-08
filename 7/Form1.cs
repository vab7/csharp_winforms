using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        static int arraySize = 16;

        int[,] array = new int[arraySize, arraySize];

        Random random = new Random();

        int size = 30;

        void createGridView()
        {
            dataGridView1.Size = new Size(size * array.GetLength(0), size * array.GetLength(1));

            dataGridView1.RowCount = array.GetLength(0);
            dataGridView1.ColumnCount = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                dataGridView1.Rows[i].Height = size;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-50, 50);

                    dataGridView1.Rows[i].Cells[j].Value = array[i, j];

                    dataGridView1.Columns[j].Width = size;
                }
            }
        }

        void createGridView2()
        {
            dataGridView2.Size = new Size(size * array.GetLength(0), size * array.GetLength(1));

            dataGridView2.RowCount = array.GetLength(0);
            dataGridView2.ColumnCount = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                dataGridView2.Rows[i].Height = size;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridView2.Columns[j].Width = size;
                }
            }
        }

        void run()
        {
            int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

            int max;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                max = array[i, 0];

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    newArray[i, j] = array[i, j];

                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }

                    dataGridView2.Rows[i].Cells[j].Value = newArray[i, j];
                }

                newArray[i, i] = max;
                dataGridView2.Rows[i].Cells[i].Value = max;
                dataGridView2[i, i].Style.BackColor = Color.Green;
            }
        }

        public Form1()
        {
            InitializeComponent();

            createGridView();

            createGridView2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            run();
        }
    }
}
