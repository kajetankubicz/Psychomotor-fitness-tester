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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Wybór testów
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }       
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            f.Show();
        }

        private void btnAcustic_Click(object sender, EventArgs e)
        {
            loadform(new acusticForm() );
        }


        private void btnReaction_Click(object sender, EventArgs e)
        {
            loadform(new reactionForm());
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            loadform(new memoryForm());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
