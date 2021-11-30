namespace Projeto_3___String___Ativ_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.numVezes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numVezes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fale Comigo!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(82, 65);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(191, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // numVezes
            // 
            this.numVezes.Location = new System.Drawing.Point(201, 137);
            this.numVezes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVezes.Name = "numVezes";
            this.numVezes.Size = new System.Drawing.Size(44, 20);
            this.numVezes.TabIndex = 2;
            this.numVezes.ValueChanged += new System.EventHandler(this.numVezes_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 386);
            this.Controls.Add(this.numVezes);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Falador";
            ((System.ComponentModel.ISupportInitialize)(this.numVezes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.NumericUpDown numVezes;
    }
}

