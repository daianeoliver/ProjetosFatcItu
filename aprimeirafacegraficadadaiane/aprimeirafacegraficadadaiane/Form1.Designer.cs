namespace aprimeirafacegraficadadaiane
{
    partial class frmExemplo
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
            this.label1 = new System.Windows.Forms.Label();
            this.Exibir = new System.Windows.Forms.Button();
            this.txtinformacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "forneça uma informação";
            // 
            // Exibir
            // 
            this.Exibir.Location = new System.Drawing.Point(77, 172);
            this.Exibir.Name = "Exibir";
            this.Exibir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Exibir.Size = new System.Drawing.Size(136, 23);
            this.Exibir.TabIndex = 1;
            this.Exibir.Text = "Exibir na MessageBox";
            this.Exibir.UseVisualStyleBackColor = true;
            this.Exibir.Click += new System.EventHandler(this.daiane_button_Click);
            // 
            // txtinformacao
            // 
            this.txtinformacao.Location = new System.Drawing.Point(95, 98);
            this.txtinformacao.Name = "txtinformacao";
            this.txtinformacao.Size = new System.Drawing.Size(100, 20);
            this.txtinformacao.TabIndex = 2;
            this.txtinformacao.TextChanged += new System.EventHandler(this.txtinformacao_TextChanged);
            // 
            // frmExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtinformacao);
            this.Controls.Add(this.Exibir);
            this.Controls.Add(this.label1);
            this.Name = "frmExemplo";
            this.Text = "Meu primeiro programa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exibir;
        private System.Windows.Forms.TextBox txtinformacao;
    }
}

