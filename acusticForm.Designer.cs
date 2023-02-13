
namespace Projekt_nr_2
{
    partial class acusticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acusticForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.trainingBox = new System.Windows.Forms.CheckBox();
            this.btnHear = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.avgResults = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 191);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Rozpocznij test";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // trainingBox
            // 
            this.trainingBox.AutoSize = true;
            this.trainingBox.Location = new System.Drawing.Point(26, 168);
            this.trainingBox.Name = "trainingBox";
            this.trainingBox.Size = new System.Drawing.Size(112, 17);
            this.trainingBox.TabIndex = 2;
            this.trainingBox.Text = "Faza Szkoleniowa";
            this.trainingBox.UseVisualStyleBackColor = true;
            // 
            // btnHear
            // 
            this.btnHear.Location = new System.Drawing.Point(167, 191);
            this.btnHear.Name = "btnHear";
            this.btnHear.Size = new System.Drawing.Size(112, 23);
            this.btnHear.TabIndex = 3;
            this.btnHear.Text = "Słyszę";
            this.btnHear.UseVisualStyleBackColor = true;
            this.btnHear.Click += new System.EventHandler(this.btnHear_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(26, 220);
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(253, 167);
            this.textBoxResults.TabIndex = 4;
            this.textBoxResults.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // avgResults
            // 
            this.avgResults.AutoSize = true;
            this.avgResults.Location = new System.Drawing.Point(23, 390);
            this.avgResults.Name = "avgResults";
            this.avgResults.Size = new System.Drawing.Size(94, 13);
            this.avgResults.TabIndex = 6;
            this.avgResults.Text = "Średnia pomiarów:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Location = new System.Drawing.Point(26, 12);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(388, 150);
            this.textBoxDescription.TabIndex = 7;
            this.textBoxDescription.Text = resources.GetString("textBoxDescription.Text");
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(285, 220);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(259, 167);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // chartBox
            // 
            this.chartBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chartBox.Location = new System.Drawing.Point(302, 194);
            this.chartBox.Name = "chartBox";
            this.chartBox.Size = new System.Drawing.Size(112, 16);
            this.chartBox.TabIndex = 9;
            this.chartBox.Text = "Wykres:";
            // 
            // acusticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.avgResults);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.btnHear);
            this.Controls.Add(this.trainingBox);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "acusticForm";
            this.Text = "acusticForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox trainingBox;
        private System.Windows.Forms.Button btnHear;
        private System.Windows.Forms.RichTextBox textBoxResults;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label avgResults;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox chartBox;
    }
}