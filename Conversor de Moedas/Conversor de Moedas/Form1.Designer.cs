namespace Conversor_de_Moedas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReal = new System.Windows.Forms.Label();
            this.lblConversao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rdbDolar = new System.Windows.Forms.RadioButton();
            this.rdbLibra = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Location = new System.Drawing.Point(169, 39);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(65, 13);
            this.lblReal.TabIndex = 0;
            this.lblReal.Text = "Valor em R$";
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.Location = new System.Drawing.Point(149, 174);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(85, 13);
            this.lblConversao.TabIndex = 1;
            this.lblConversao.Text = "Valor Convertido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // rdbDolar
            // 
            this.rdbDolar.AutoSize = true;
            this.rdbDolar.Location = new System.Drawing.Point(12, 98);
            this.rdbDolar.Name = "rdbDolar";
            this.rdbDolar.Size = new System.Drawing.Size(50, 17);
            this.rdbDolar.TabIndex = 4;
            this.rdbDolar.TabStop = true;
            this.rdbDolar.Text = "Dólar";
            this.rdbDolar.UseVisualStyleBackColor = true;
            // 
            // rdbLibra
            // 
            this.rdbLibra.AutoSize = true;
            this.rdbLibra.Location = new System.Drawing.Point(12, 121);
            this.rdbLibra.Name = "rdbLibra";
            this.rdbLibra.Size = new System.Drawing.Size(48, 17);
            this.rdbLibra.TabIndex = 5;
            this.rdbLibra.TabStop = true;
            this.rdbLibra.Text = "Libra";
            this.rdbLibra.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(12, 144);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(47, 17);
            this.rdbEuro.TabIndex = 6;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 101);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(12, 226);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 9;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(105, 226);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(197, 226);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.rdbEuro);
            this.Controls.Add(this.rdbLibra);
            this.Controls.Add(this.rdbDolar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConversao);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Conversor de Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblConversao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rdbDolar;
        private System.Windows.Forms.RadioButton rdbLibra;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

