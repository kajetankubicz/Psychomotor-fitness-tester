
namespace Projekt_nr_2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAcustic = new System.Windows.Forms.Button();
            this.btnReaction = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.panelside = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelheader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panelside.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAcustic
            // 
            this.btnAcustic.BackColor = System.Drawing.Color.DimGray;
            this.btnAcustic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcustic.FlatAppearance.BorderSize = 0;
            this.btnAcustic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcustic.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAcustic.ForeColor = System.Drawing.Color.White;
            this.btnAcustic.Location = new System.Drawing.Point(0, 88);
            this.btnAcustic.Name = "btnAcustic";
            this.btnAcustic.Size = new System.Drawing.Size(203, 79);
            this.btnAcustic.TabIndex = 2;
            this.btnAcustic.Text = "Test akustyczny";
            this.btnAcustic.UseVisualStyleBackColor = false;
            this.btnAcustic.Click += new System.EventHandler(this.btnAcustic_Click);
            // 
            // btnReaction
            // 
            this.btnReaction.BackColor = System.Drawing.Color.DimGray;
            this.btnReaction.FlatAppearance.BorderSize = 0;
            this.btnReaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReaction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReaction.ForeColor = System.Drawing.Color.White;
            this.btnReaction.Location = new System.Drawing.Point(0, 173);
            this.btnReaction.Name = "btnReaction";
            this.btnReaction.Size = new System.Drawing.Size(200, 79);
            this.btnReaction.TabIndex = 3;
            this.btnReaction.Text = "Test reakcyjny";
            this.btnReaction.UseVisualStyleBackColor = false;
            this.btnReaction.Click += new System.EventHandler(this.btnReaction_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.FlatAppearance.BorderSize = 0;
            this.btnMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMemory.ForeColor = System.Drawing.Color.White;
            this.btnMemory.Location = new System.Drawing.Point(0, 258);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(200, 79);
            this.btnMemory.TabIndex = 4;
            this.btnMemory.Text = "Test pamięci";
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.DimGray;
            this.panelside.Controls.Add(this.richTextBox1);
            this.panelside.Controls.Add(this.btnAcustic);
            this.panelside.Controls.Add(this.btnReaction);
            this.panelside.Controls.Add(this.btnMemory);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 30);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(200, 420);
            this.panelside.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(9, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(188, 44);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Wybierz test, który chcesz przeprowadzić:";
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Gray;
            this.panelheader.Controls.Add(this.btnClose);
            this.panelheader.Controls.Add(this.textBox3);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(800, 30);
            this.panelheader.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(767, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(9, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(409, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Witamy w testerze sprawności psychomotorycznej";
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.richTextBox2);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(600, 420);
            this.mainpanel.TabIndex = 8;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox2.Location = new System.Drawing.Point(9, 112);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(582, 278);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tester sprawności psychomotorycznej";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelside.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAcustic;
        private System.Windows.Forms.Button btnReaction;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

