namespace Incrementar
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
            this.dieLabel1 = new System.Windows.Forms.PictureBox();
            this.dieLabel2 = new System.Windows.Forms.PictureBox();
            this.dieLabel3 = new System.Windows.Forms.PictureBox();
            this.dieLabel4 = new System.Windows.Forms.PictureBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dieLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieLabel4)).BeginInit();
            this.SuspendLayout();
            // 
            // dieLabel1
            // 
            this.dieLabel1.Image = global::Incrementar.Properties.Resources.die6;
            this.dieLabel1.Location = new System.Drawing.Point(42, 52);
            this.dieLabel1.Name = "dieLabel1";
            this.dieLabel1.Size = new System.Drawing.Size(59, 50);
            this.dieLabel1.TabIndex = 0;
            this.dieLabel1.TabStop = false;
            this.dieLabel1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dieLabel2
            // 
            this.dieLabel2.Image = global::Incrementar.Properties.Resources.die1;
            this.dieLabel2.Location = new System.Drawing.Point(201, 52);
            this.dieLabel2.Name = "dieLabel2";
            this.dieLabel2.Size = new System.Drawing.Size(61, 50);
            this.dieLabel2.TabIndex = 1;
            this.dieLabel2.TabStop = false;
            // 
            // dieLabel3
            // 
            this.dieLabel3.Image = global::Incrementar.Properties.Resources.die1;
            this.dieLabel3.Location = new System.Drawing.Point(42, 155);
            this.dieLabel3.Name = "dieLabel3";
            this.dieLabel3.Size = new System.Drawing.Size(59, 50);
            this.dieLabel3.TabIndex = 2;
            this.dieLabel3.TabStop = false;
            // 
            // dieLabel4
            // 
            this.dieLabel4.Image = global::Incrementar.Properties.Resources.die1;
            this.dieLabel4.Location = new System.Drawing.Point(201, 155);
            this.dieLabel4.Name = "dieLabel4";
            this.dieLabel4.Size = new System.Drawing.Size(61, 50);
            this.dieLabel4.TabIndex = 3;
            this.dieLabel4.TabStop = false;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(116, 233);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 4;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(140, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 268);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.dieLabel4);
            this.Controls.Add(this.dieLabel3);
            this.Controls.Add(this.dieLabel2);
            this.Controls.Add(this.dieLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dieLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieLabel4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dieLabel1;
        private System.Windows.Forms.PictureBox dieLabel2;
        private System.Windows.Forms.PictureBox dieLabel3;
        private System.Windows.Forms.PictureBox dieLabel4;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label lblResult;
    }
}

