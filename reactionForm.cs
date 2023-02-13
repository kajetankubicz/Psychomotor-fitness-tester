using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_nr_2
{
    public partial class reactionForm : Form
    {
        Random rand = new Random();
        Stopwatch reactionStamp = new Stopwatch();
        List<int> reactiontestResults = new List<int>(); //y values
        List<int> mesurments = new List<int>(); //x values
        bool reactionTest = false;
        int measureTry = 0;

        public reactionForm()
        {
            InitializeComponent();
            avgResults.Visible = false;
            chartBox.Visible = false;
            chart1.Series["Series1"].IsVisibleInLegend = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            reactionTest = !reactionTest;
            if (reactionTest)
            {
                btnStart.Text = "Przerwij test";
                textBoxResults.Text = " ";
                colorBox.Enabled = true;
                timer1.Enabled = true;
                timer1.Interval = rand.Next(3000, 4000);
                avgResults.Visible = false;
            }
            else
            {
                btnStart.Text = "Rozpocznij test";
                colorBox.Enabled = false;
                timer1.Enabled = false;
                avgResults.Visible = true;
                chartBox.Visible = true;
                chart1.Series["Series1"].Points.DataBindXY(mesurments, reactiontestResults);
            }
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            if (reactionStamp.IsRunning)
            {
                reactionStamp.Stop();
                colorBox.BackColor = Color.Crimson;
                if (!checkBox1.Checked)
                {
                    int reactionTime = (int)reactionStamp.ElapsedMilliseconds;                
                    textBoxResults.Text = textBoxResults.Text + (reactionTime.ToString() + "ms.\n");
                    mesurments.Add(measureTry);
                    measureTry++;
                    reactiontestResults.Add(reactionTime);
                    avgResults.Text = "Średnia z pomiarów: " + reactiontestResults.Average() + "ms";
                    timer1.Interval = rand.Next(2000, 5000);
                }
            }
            else
            {
                MessageBox.Show("Za szybko!");
                reactionStamp.Stop();
                reactionStamp.Reset();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (!reactionStamp.IsRunning)
            {
                reactionStamp.Reset();
                if (reactionTest) colorBox.BackColor = Color.Green;
                reactionStamp.Start();

            }
        }
    }
}
