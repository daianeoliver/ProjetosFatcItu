namespace WindowsFormsApplication6
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
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.txtinformacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(86, 138);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(124, 23);
            this.btnExibir.TabIndex = 0;
            this.btnExibir.Text = "Exibir na MessageBox";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Location = new System.Drawing.Point(80, 48);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(130, 13);
            this.lblExemplo.TabIndex = 1;
            this.lblExemplo.Text = "Forneça uma informação: ";
            this.lblExemplo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtinformacao
            // 
            this.txtinformacao.Location = new System.Drawing.Point(34, 83);
            this.txtinformacao.Name = "txtinformacao";
            this.txtinformacao.Size = new System.Drawing.Size(225, 20);
            this.txtinformacao.TabIndex = 2;
            // 
            // frmExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtinformacao);
            this.Controls.Add(this.lblExemplo);
            this.Controls.Add(this.btnExibir);
            this.Name = "frmExemplo";
            this.Text = "Exemplo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblExemplo;
        private System.Windows.Forms.TextBox txtinformacao;
    }
}

