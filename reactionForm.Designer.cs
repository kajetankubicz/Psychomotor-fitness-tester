
namespace Projekt_nr_2
{
    partial class reactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reactionForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.textBoxResults = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.avgResults = new System.Windows.Forms.Label();
            this.chartBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 220);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Rozpocznij test";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Crimson;
            this.colorBox.Location = new System.Drawing.Point(26, 264);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(111, 96);
            this.colorBox.TabIndex = 1;
            this.colorBox.TabStop = false;
            this.colorBox.Click += new System.EventHandler(this.colorBox_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.BackColor = System.Drawing.Color.White;
            this.textBoxResults.Location = new System.Drawing.Point(143, 207);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(104, 153);
            this.textBoxResults.TabIndex = 2;
            this.textBoxResults.Text = "";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(264, 207);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(285, 164);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(26, 13);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(370, 163);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Faza szkoleniowa";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // avgResults
            // 
            this.avgResults.AutoSize = true;
            this.avgResults.Location = new System.Drawing.Point(43, 383);
            this.avgResults.Name = "avgResults";
            this.avgResults.Size = new System.Drawing.Size(94, 13);
            this.avgResults.TabIndex = 6;
            this.avgResults.Text = "Średnia pomiarów:";
            // 
            // chartBox
            // 
            this.chartBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chartBox.Location = new System.Drawing.Point(264, 182);
            this.chartBox.Name = "chartBox";
            this.chartBox.Size = new System.Drawing.Size(100, 16);
            this.chartBox.TabIndex = 7;
            this.chartBox.Text = "Wykres:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // reactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartBox);
            this.Controls.Add(this.avgResults);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reactionForm";
            this.Text = "reactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.RichTextBox textBoxResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label avgResults;
        private System.Windows.Forms.TextBox chartBox;
        private System.Windows.Forms.Timer timer1;
    }
}