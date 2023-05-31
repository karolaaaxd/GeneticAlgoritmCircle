using Projekt2.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projekt2
{
    public partial class Form1 : Form
    {
        private List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            await new GA().Calc(points,Convert.ToInt32(popul_size_textbox.Text),Convert.ToInt32(max_iter_textbox.Text),Convert.ToSingle(mut_rate_textBox.Text),Convert.ToSingle(cross_rate_textBox.Text),selection_comboBox.SelectedIndex,drawer,iterationsTextBox,best1, bestX, bestY, Diameter1);
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = Convert.ToSingle(pointX_textBox.Text);
            double x = Convert.ToSingle(pointY_textBox.Text);
            points.Add(new Point(x, y));
            pointX_textBox.Text = "";
            pointY_textBox.Text = "";
            pointsArea.Text = pointsArea.Text + $"X={x}, Y={y}\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pointsArea.Text != "")
            {
                popul_size_textbox.Text = "";
                max_iter_textbox.Text = "";
                mut_rate_textBox.Text = "";
                cross_rate_textBox.Text = "";
                selection_comboBox.SelectedIndex = -1;
                pointsArea.Text = "";
            }
            else
            {
                Point p1 = new Point(0.3, 0.5);
                Point p2 = new Point(0.1, 0.3);
                Point p3 = new Point(0.4, 0.2);
                points.Add(p1);
                points.Add(p2);
                points.Add(p3);
                pointsArea.Text = pointsArea.Text + $"X={p1.X}, Y={p1.Y}\r\nX={p2.X}, Y={p2.Y}\r\nX={p3.X}, Y={p3.Y}\r\n";

                popul_size_textbox.Text = "100";
                max_iter_textbox.Text = "100";
                mut_rate_textBox.Text = "0,1";
                cross_rate_textBox.Text = "0,01";
                selection_comboBox.SelectedIndex = 0;
            }
            
        }
    }
}
