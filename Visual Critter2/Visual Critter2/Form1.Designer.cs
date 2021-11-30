namespace Visual_Critter2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cboMood = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.scrSize = new System.Windows.Forms.HScrollBar();
            this.picCritter = new System.Windows.Forms.PictureBox();
            this.picHappy = new System.Windows.Forms.PictureBox();
            this.picIndiff = new System.Windows.Forms.PictureBox();
            this.picMed = new System.Windows.Forms.PictureBox();
            this.cmdName = new System.Windows.Forms.Button();
            this.lbltext = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCritter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMed)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMood
            // 
            this.cboMood.FormattingEnabled = true;
            this.cboMood.Items.AddRange(new object[] {
            "feliz",
            "indiferente",
            "louco"});
            this.cboMood.Location = new System.Drawing.Point(26, 62);
            this.cboMood.Name = "cboMood";
            this.cboMood.Size = new System.Drawing.Size(142, 21);
            this.cboMood.TabIndex = 0;
            this.cboMood.SelectedIndexChanged += new System.EventHandler(this.cboMood_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 1;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(26, 269);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 17);
            this.radRed.TabIndex = 2;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(26, 292);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 3;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(26, 315);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 4;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // scrSize
            // 
            this.scrSize.Location = new System.Drawing.Point(26, 410);
            this.scrSize.Maximum = 300;
            this.scrSize.Minimum = 50;
            this.scrSize.Name = "scrSize";
            this.scrSize.Size = new System.Drawing.Size(142, 22);
            this.scrSize.TabIndex = 5;
            this.scrSize.Value = 50;
            this.scrSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrSize_Scroll);
            // 
            // picCritter
            // 
            this.picCritter.Location = new System.Drawing.Point(253, 42);
            this.picCritter.Name = "picCritter";
            this.picCritter.Size = new System.Drawing.Size(618, 257);
            this.picCritter.TabIndex = 6;
            this.picCritter.TabStop = false;
            this.picCritter.Click += new System.EventHandler(this.picCritter_Click);
            // 
            // picHappy
            // 
            this.picHappy.Image = ((System.Drawing.Image)(resources.GetObject("picHappy.Image")));
            this.picHappy.Location = new System.Drawing.Point(227, 305);
            this.picHappy.Name = "picHappy";
            this.picHappy.Size = new System.Drawing.Size(212, 148);
            this.picHappy.TabIndex = 8;
            this.picHappy.TabStop = false;
            this.picHappy.Visible = false;
            // 
            // picIndiff
            // 
            this.picIndiff.Image = ((System.Drawing.Image)(resources.GetObject("picIndiff.Image")));
            this.picIndiff.Location = new System.Drawing.Point(445, 305);
            this.picIndiff.Name = "picIndiff";
            this.picIndiff.Size = new System.Drawing.Size(208, 148);
            this.picIndiff.TabIndex = 9;
            this.picIndiff.TabStop = false;
            this.picIndiff.Visible = false;
            // 
            // picMed
            // 
            this.picMed.Image = ((System.Drawing.Image)(resources.GetObject("picMed.Image")));
            this.picMed.Location = new System.Drawing.Point(659, 305);
            this.picMed.Name = "picMed";
            this.picMed.Size = new System.Drawing.Size(207, 148);
            this.picMed.TabIndex = 10;
            this.picMed.TabStop = false;
            this.picMed.Visible = false;
            // 
            // cmdName
            // 
            this.cmdName.Location = new System.Drawing.Point(26, 182);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(142, 23);
            this.cmdName.TabIndex = 11;
            this.cmdName.Text = "OK";
            this.cmdName.UseVisualStyleBackColor = true;
            this.cmdName.Click += new System.EventHandler(this.cmdName_Click);
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(253, 13);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(0, 13);
            this.lbltext.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cor de fundo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tamanho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.cmdName);
            this.Controls.Add(this.picMed);
            this.Controls.Add(this.picIndiff);
            this.Controls.Add(this.picHappy);
            this.Controls.Add(this.picCritter);
            this.Controls.Add(this.scrSize);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.radGreen);
            this.Controls.Add(this.radRed);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboMood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCritter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMood;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.HScrollBar scrSize;
        private System.Windows.Forms.PictureBox picCritter;
        private System.Windows.Forms.PictureBox picHappy;
        private System.Windows.Forms.PictureBox picIndiff;
        private System.Windows.Forms.PictureBox picMed;
        private System.Windows.Forms.Button cmdName;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

