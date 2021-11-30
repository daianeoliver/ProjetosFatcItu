namespace Array_Linguagens
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
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.optUnsorted = new System.Windows.Forms.RadioButton();
            this.optSorted = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnForEach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 12);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(176, 173);
            this.lstOutput.TabIndex = 0;
            // 
            // optUnsorted
            // 
            this.optUnsorted.AutoSize = true;
            this.optUnsorted.Location = new System.Drawing.Point(12, 191);
            this.optUnsorted.Name = "optUnsorted";
            this.optUnsorted.Size = new System.Drawing.Size(95, 17);
            this.optUnsorted.TabIndex = 1;
            this.optUnsorted.TabStop = true;
            this.optUnsorted.Text = "Não Ordenado";
            this.optUnsorted.UseVisualStyleBackColor = true;
            this.optUnsorted.CheckedChanged += new System.EventHandler(this.optUnsorted_CheckedChanged);
            // 
            // optSorted
            // 
            this.optSorted.AutoSize = true;
            this.optSorted.Location = new System.Drawing.Point(112, 191);
            this.optSorted.Name = "optSorted";
            this.optSorted.Size = new System.Drawing.Size(72, 17);
            this.optSorted.TabIndex = 2;
            this.optSorted.TabStop = true;
            this.optSorted.Text = "Ordenado";
            this.optSorted.UseVisualStyleBackColor = true;
            this.optSorted.CheckedChanged += new System.EventHandler(this.optSorted_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(103, 229);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnForEach
            // 
            this.btnForEach.Location = new System.Drawing.Point(197, 191);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(75, 23);
            this.btnForEach.TabIndex = 5;
            this.btnForEach.Text = "ForEach";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnForEach);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.optSorted);
            this.Controls.Add(this.optUnsorted);
            this.Controls.Add(this.lstOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.RadioButton optUnsorted;
        private System.Windows.Forms.RadioButton optSorted;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnForEach;
    }
}

