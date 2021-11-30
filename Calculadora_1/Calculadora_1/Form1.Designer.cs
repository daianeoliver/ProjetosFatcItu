namespace Calculadora_1
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
            this.btnSomatoria = new System.Windows.Forms.Button();
            this.btnImpares = new System.Windows.Forms.Button();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSomatoria
            // 
            this.btnSomatoria.Location = new System.Drawing.Point(34, 96);
            this.btnSomatoria.Name = "btnSomatoria";
            this.btnSomatoria.Size = new System.Drawing.Size(100, 30);
            this.btnSomatoria.TabIndex = 0;
            this.btnSomatoria.Text = "Somatoria";
            this.btnSomatoria.UseVisualStyleBackColor = true;
            this.btnSomatoria.Click += new System.EventHandler(this.btnSomatoria_Click);
            // 
            // btnImpares
            // 
            this.btnImpares.Location = new System.Drawing.Point(34, 146);
            this.btnImpares.Name = "btnImpares";
            this.btnImpares.Size = new System.Drawing.Size(100, 32);
            this.btnImpares.TabIndex = 1;
            this.btnImpares.Text = "Soma Impares";
            this.btnImpares.UseVisualStyleBackColor = true;
            this.btnImpares.Click += new System.EventHandler(this.btnImpares_Click);
            // 
            // btnFatorial
            // 
            this.btnFatorial.Location = new System.Drawing.Point(34, 202);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(100, 32);
            this.btnFatorial.TabIndex = 2;
            this.btnFatorial.Text = "Fatorial";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(168, 202);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(95, 32);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(34, 47);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.btnImpares);
            this.Controls.Add(this.btnSomatoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomatoria;
        private System.Windows.Forms.Button btnImpares;
        private System.Windows.Forms.Button btnFatorial;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtnumero;
    }
}

