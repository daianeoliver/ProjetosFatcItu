namespace Font_Chooser
{
    partial class myForm
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.rad20 = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(64, 34);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(62, 13);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Simple Text";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Comic Sans MS"});
            this.listBox1.Location = new System.Drawing.Point(12, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 56);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Location = new System.Drawing.Point(23, 158);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(51, 17);
            this.rad10.TabIndex = 2;
            this.rad10.TabStop = true;
            this.rad10.Text = "10pts";
            this.rad10.UseVisualStyleBackColor = true;
            this.rad10.CheckedChanged += new System.EventHandler(this.rad10_CheckedChanged);
            // 
            // rad20
            // 
            this.rad20.AutoSize = true;
            this.rad20.Location = new System.Drawing.Point(23, 202);
            this.rad20.Name = "rad20";
            this.rad20.Size = new System.Drawing.Size(51, 17);
            this.rad20.TabIndex = 3;
            this.rad20.TabStop = true;
            this.rad20.Text = "20pts";
            this.rad20.UseVisualStyleBackColor = true;
            this.rad20.CheckedChanged += new System.EventHandler(this.rad20_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(128, 158);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(47, 17);
            this.chkBold.TabIndex = 4;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(128, 202);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(48, 17);
            this.chkItalic.TabIndex = 5;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.rad20);
            this.Controls.Add(this.rad10);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblOutput);
            this.Name = "myForm";
            this.Text = "Font Chooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.RadioButton rad20;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
    }
}

