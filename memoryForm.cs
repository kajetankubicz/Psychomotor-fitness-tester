using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_nr_2
{
    public partial class memoryForm : Form
    {
        Random rand = new Random();
        List<string> icons = new List<string>()
        {
            "@","@","M","M",",",",","Z","Z",
            "b","b","v","v","W","W","G","G"
        };
        Label firstCliked, secondClicked;
        int seconds = 0;


        public memoryForm()
        {
            InitializeComponent();
            AssignIonsToSquares();
            labelTimer.Visible = false;         
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer2.Start();
            btnStart.Text = null;
            checkBox1.Enabled = false;
        }

        private void labelClick(object sender, EventArgs e)
        {
            if(firstCliked != null && secondClicked != null)
            {
                return;
            }

            Label clickedLabel = sender as Label;
            if(clickedLabel == null)
            {
                return;
            }
            if(clickedLabel.ForeColor == Color.Black)
            {
                return;
            }
            if(firstCliked == null)
            {
                firstCliked = clickedLabel;
                firstCliked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            CheckGame();

            if(firstCliked.Text == secondClicked.Text)
            {
                firstCliked = null;
                secondClicked = null;
            }
            else
            {
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstCliked.ForeColor = firstCliked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstCliked = null;
            secondClicked = null;
        }

        private void AssignIonsToSquares()
        {
            Label label;
            int randomNum;

            for(int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if(tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                }
                else
                {
                    continue;
                }
                randomNum = rand.Next(0, icons.Count);
                label.Text = icons[randomNum];       
                icons.RemoveAt(randomNum);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds++;
            labelTimer.Text = "Twój test trwał " + (seconds / 10).ToString() + " sekundy";

        }

        private void CheckGame()
        {
            if (!checkBox1.Checked)
            {
                Label label;
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    label = tableLayoutPanel1.Controls[i] as Label;
                    if (label != null && label.ForeColor == label.BackColor)
                    {
                        return;
                    }

                }
                labelTimer.Visible = true;
                timer2.Stop();
                MessageBox.Show("Koniec testu w " + (seconds / 10).ToString() + " sekundy");
            }
            
        }

    }
}
