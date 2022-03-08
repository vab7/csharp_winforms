using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        double Xmin = -2.4;
        double Xmax = 1;
        double Step = 0.2;

        void showChart()
        {
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);

            const double b = 2.5;

            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

            double[] x = new double[count];

            double[] y1 = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;

                y1[i] = 9 * (x[i] + 15 * Math.Sqrt(Math.Pow(x[i], 3) + Math.Pow(b, 3)));
            }

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].Color = Color.Blue;

            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            chart1.Series[0].Points.DataBindXY(x, y1);
        }

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = $"{Xmin}";
            textBox2.Text = $"{Xmax}";
            textBox3.Text = $"{Step}";

            showChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showChart();
        }
    }
}
