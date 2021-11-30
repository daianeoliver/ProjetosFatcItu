namespace WindowsFormsApplication4
{
    partial class frmExemplo02
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
            this.radVermelho = new System.Windows.Forms.RadioButton();
            this.radAmarelo = new System.Windows.Forms.RadioButton();
            this.radVerde = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblVermelho = new System.Windows.Forms.Label();
            this.lblAmarelo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radVermelho
            // 
            this.radVermelho.AutoSize = true;
            this.radVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVermelho.Location = new System.Drawing.Point(57, 80);
            this.radVermelho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radVermelho.Name = "radVermelho";
            this.radVermelho.Size = new System.Drawing.Size(95, 24);
            this.radVermelho.TabIndex = 0;
            this.radVermelho.TabStop = true;
            this.radVermelho.Text = "Vermelho";
            this.radVermelho.UseVisualStyleBackColor = true;
            this.radVermelho.CheckedChanged += new System.EventHandler(this.radVermelho_CheckedChanged);
            // 
            // radAmarelo
            // 
            this.radAmarelo.AutoSize = true;
            this.radAmarelo.Location = new System.Drawing.Point(57, 118);
            this.radAmarelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radAmarelo.Name = "radAmarelo";
            this.radAmarelo.Size = new System.Drawing.Size(86, 24);
            this.radAmarelo.TabIndex = 1;
            this.radAmarelo.TabStop = true;
            this.radAmarelo.Text = "Amarelo";
            this.radAmarelo.UseVisualStyleBackColor = true;
            this.radAmarelo.CheckedChanged += new System.EventHandler(this.radAmarelo_CheckedChanged);
            // 
            // radVerde
            // 
            this.radVerde.AutoSize = true;
            this.radVerde.Location = new System.Drawing.Point(57, 156);
            this.radVerde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radVerde.Name = "radVerde";
            this.radVerde.Size = new System.Drawing.Size(70, 24);
            this.radVerde.TabIndex = 2;
            this.radVerde.TabStop = true;
            this.radVerde.Text = "Verde";
            this.radVerde.UseVisualStyleBackColor = true;
            this.radVerde.CheckedChanged += new System.EventHandler(this.radVerde_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(151, 229);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblVermelho
            // 
            this.lblVermelho.BackColor = System.Drawing.Color.Red;
            this.lblVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVermelho.ForeColor = System.Drawing.Color.White;
            this.lblVermelho.Location = new System.Drawing.Point(288, 82);
            this.lblVermelho.Name = "lblVermelho";
            this.lblVermelho.Size = new System.Drawing.Size(104, 22);
            this.lblVermelho.TabIndex = 4;
            this.lblVermelho.Text = "PARE";
            this.lblVermelho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVermelho.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAmarelo
            // 
            this.lblAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.lblAmarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmarelo.ForeColor = System.Drawing.Color.Black;
            this.lblAmarelo.Location = new System.Drawing.Point(288, 118);
            this.lblAmarelo.Name = "lblAmarelo";
            this.lblAmarelo.Size = new System.Drawing.Size(104, 22);
            this.lblAmarelo.TabIndex = 5;
            this.lblAmarelo.Text = "ESPERE";
            this.lblAmarelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVerde
            // 
            this.lblVerde.BackColor = System.Drawing.Color.Green;
            this.lblVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.ForeColor = System.Drawing.Color.White;
            this.lblVerde.Location = new System.Drawing.Point(288, 156);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(104, 22);
            this.lblVerde.TabIndex = 6;
            this.lblVerde.Text = "SIGA";
            this.lblVerde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmExemplo02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 317);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblAmarelo);
            this.Controls.Add(this.lblVermelho);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.radVerde);
            this.Controls.Add(this.radAmarelo);
            this.Controls.Add(this.radVermelho);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExemplo02";
            this.Text = "Semáforo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radVermelho;
        private System.Windows.Forms.RadioButton radAmarelo;
        private System.Windows.Forms.RadioButton radVerde;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblVermelho;
        private System.Windows.Forms.Label lblAmarelo;
        private System.Windows.Forms.Label lblVerde;
    }
}

