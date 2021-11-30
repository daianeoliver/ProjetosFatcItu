namespace Tabuaba
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
            this.lblCrescente = new System.Windows.Forms.Label();
            this.lblDecrescente = new System.Windows.Forms.Label();
            this.lblCresce = new System.Windows.Forms.Label();
            this.lblDecresce = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCrescente
            // 
            this.lblCrescente.Location = new System.Drawing.Point(27, 101);
            this.lblCrescente.Name = "lblCrescente";
            this.lblCrescente.Size = new System.Drawing.Size(89, 151);
            this.lblCrescente.TabIndex = 0;
            // 
            // lblDecrescente
            // 
            this.lblDecrescente.Location = new System.Drawing.Point(165, 101);
            this.lblDecrescente.Name = "lblDecrescente";
            this.lblDecrescente.Size = new System.Drawing.Size(89, 151);
            this.lblDecrescente.TabIndex = 1;
            // 
            // lblCresce
            // 
            this.lblCresce.AutoSize = true;
            this.lblCresce.Location = new System.Drawing.Point(30, 71);
            this.lblCresce.Name = "lblCresce";
            this.lblCresce.Size = new System.Drawing.Size(55, 13);
            this.lblCresce.TabIndex = 2;
            this.lblCresce.Text = "Crescente";
            // 
            // lblDecresce
            // 
            this.lblDecresce.AutoSize = true;
            this.lblDecresce.Location = new System.Drawing.Point(168, 70);
            this.lblDecresce.Name = "lblDecresce";
            this.lblDecresce.Size = new System.Drawing.Size(68, 13);
            this.lblDecresce.TabIndex = 3;
            this.lblDecresce.Text = "Decrescente";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(118, 13);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(53, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(189, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(46, 20);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tabuada do: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblDecresce);
            this.Controls.Add(this.lblCresce);
            this.Controls.Add(this.lblDecrescente);
            this.Controls.Add(this.lblCrescente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrescente;
        private System.Windows.Forms.Label lblDecrescente;
        private System.Windows.Forms.Label lblCresce;
        private System.Windows.Forms.Label lblDecresce;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}

