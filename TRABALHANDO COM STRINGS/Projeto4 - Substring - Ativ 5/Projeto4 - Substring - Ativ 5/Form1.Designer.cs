namespace Projeto4___Substring___Ativ_5
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
            this.btnProcurar = new System.Windows.Forms.Button();
            this.lblFrase = new System.Windows.Forms.Label();
            this.lblProcura = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(110, 179);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(36, 38);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(95, 13);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Forneça uma frase";
            // 
            // lblProcura
            // 
            this.lblProcura.AutoSize = true;
            this.lblProcura.Location = new System.Drawing.Point(36, 117);
            this.lblProcura.Name = "lblProcura";
            this.lblProcura.Size = new System.Drawing.Size(129, 13);
            this.lblProcura.TabIndex = 2;
            this.lblProcura.Text = "Forneça a letra a procurar";
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(39, 54);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(205, 20);
            this.txtFrase.TabIndex = 3;
            this.txtFrase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(39, 133);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(49, 20);
            this.txtLetra.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lblProcura);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.btnProcurar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Label lblProcura;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.TextBox txtLetra;
    }
}

