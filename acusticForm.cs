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
    public partial class acusticForm : Form
    {
        Random rand = new Random();
        Stopwatch measuredTime = new Stopwatch();
        List<int> hearingtestResults = new List<int>(); //y values
        List<int> mesurments = new List<int>(); //x values
        bool hearTest = false;
        int measureTry = 0;
  
        public acusticForm()
        {
            InitializeComponent();
            avgResults.Visible = false;
            chartBox.Visible = false;
            chart1.Series["Series1"].IsVisibleInLegend = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hearTest = !hearTest;
            if(hearTest)
            {
                btnStart.Text = "Przerwij test";
                textBoxResults.Text = " ";
                timer1.Enabled = true;
                timer1.Interval = rand.Next(3000, 4000);
                avgResults.Visible = false;
            }
            else
            {
                btnStart.Text = "Rozpocznij test";
                timer1.Enabled = false;
                avgResults.Visible = true;
                chartBox.Visible = true;
                chart1.Series["Series1"].Points.DataBindXY(mesurments, hearingtestResults);
            }       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!measuredTime.IsRunning)
            {
                measuredTime.Reset();
                if (hearTest) Console.Beep();
                measuredTime.Start();

            }
        }

        private void btnHear_Click(object sender, EventArgs e)
        {
            if (measuredTime.IsRunning)
            {
                measuredTime.Stop();
                if (!trainingBox.Checked)
                {
                    int reactionTime = (int)measuredTime.ElapsedMilliseconds;                  
                    textBoxResults.Text = textBoxResults.Text + (reactionTime.ToString() + "ms.\n");             
                    mesurments.Add(measureTry);
                    measureTry++;
                    hearingtestResults.Add(reactionTime);
                    avgResults.Text = "Średnia z pomiarów: " + hearingtestResults.Average() + "ms";
                    timer1.Interval = rand.Next(2000, 5000);
                }
            }
            else
            {
                MessageBox.Show("Za szybko!");
                measuredTime.Stop();
                measuredTime.Reset();
            }
        }

    }
}
