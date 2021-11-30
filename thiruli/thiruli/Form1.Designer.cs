namespace thiruli
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
            this.lblsalario = new System.Windows.Forms.Label();
            this.lblquilowatt = new System.Windows.Forms.Label();
            this.lblVLQuilowatt = new System.Windows.Forms.Label();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(44, 34);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(83, 13);
            this.lblsalario.TabIndex = 0;
            this.lblsalario.Text = "Salário Mínimo: ";
            // 
            // lblquilowatt
            // 
            this.lblquilowatt.AutoSize = true;
            this.lblquilowatt.Location = new System.Drawing.Point(16, 68);
            this.lblquilowatt.Name = "lblquilowatt";
            this.lblquilowatt.Size = new System.Drawing.Size(120, 13);
            this.lblquilowatt.TabIndex = 1;
            this.lblquilowatt.Text = "Quantidade Quilowatts: ";
            // 
            // lblVLQuilowatt
            // 
            this.lblVLQuilowatt.AutoSize = true;
            this.lblVLQuilowatt.Location = new System.Drawing.Point(49, 98);
            this.lblVLQuilowatt.Name = "lblVLQuilowatt";
            this.lblVLQuilowatt.Size = new System.Drawing.Size(84, 13);
            this.lblVLQuilowatt.TabIndex = 2;
            this.lblVLQuilowatt.Text = "Valor Quilowatt: ";
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Location = new System.Drawing.Point(40, 131);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(93, 13);
            this.lblResidencia.TabIndex = 3;
            this.lblResidencia.Text = "Valor Residência: ";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(18, 165);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(109, 13);
            this.lblDesconto.TabIndex = 4;
            this.lblDesconto.Text = "Valor com Desconto: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(133, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(133, 162);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblResidencia);
            this.Controls.Add(this.lblVLQuilowatt);
            this.Controls.Add(this.lblquilowatt);
            this.Controls.Add(this.lblsalario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.Label lblquilowatt;
        private System.Windows.Forms.Label lblVLQuilowatt;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

